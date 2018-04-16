using Nettolicious.Common.Logging;
using DPR = Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace Nettolicious.Common.Data
{
	public partial class QueryParser : IQueryParser
	{
		private readonly ILogger mLogger;

		public QueryParser(ILogger logger = null)
		{
			mLogger = logger ?? new NullLogger();
		}

    public QueryParserResult Parse<T>(IDictionary<string, string> queryParams)
		{
			var result = new QueryParserResult
			{
				Ok = true,
				QueryParameters = new QueryParameters()
			};
			if (queryParams.Count == 0)
			{
				return result;
			}
			List<PropertyInfo> properties = typeof(T).GetProperties().ToList();
			StringBuilder predicate = new StringBuilder("WHERE 1 = 1");
			StringBuilder orderBy = new StringBuilder("ORDER BY ");
			var parameters = new DPR.DynamicParameters();
			foreach (var kvp in queryParams)
			{
				PropertyInfo propertyInfo;
				if (kvp.Key.Equals("skip", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(kvp.Value))
				{
					int skip;
					if (!int.TryParse(kvp.Value, out skip))
					{
						result.Ok = false;
						result.Error = String.Format("Failed to parse skip value '{0}' as int", kvp.Value);
						return result;
					}
					result.QueryParameters.Skip = skip;
				}
				else if (kvp.Key.Equals("take", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(kvp.Value))
				{
					int take;
					if (!int.TryParse(kvp.Value, out take))
					{
						result.Ok = false;
						result.Error = String.Format("Failed to parse take value '{0}' as int", kvp.Value);
						return result;
					}
					result.QueryParameters.Take = take;
				}
				else if (kvp.Key.Equals("sort", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(kvp.Value))
				{
					string[] sortParams = kvp.Value.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
					foreach (var sortParam in sortParams)
					{
						bool desc = sortParam[0] == '-';
						var sortParamName = sortParam.TrimStart(new char[] { '-' });
						if ((propertyInfo = properties.Where(p => p.Name.Equals(sortParamName, StringComparison.OrdinalIgnoreCase)).FirstOrDefault()) != null)
						{
							orderBy.AppendFormat("[{0}]", propertyInfo.Name);
							if (desc)
							{
								orderBy.Append(" DESC");
							}
							orderBy.Append(",");
						}
					}
				}
				else if ((propertyInfo = properties.Where(p => p.Name.Equals(kvp.Key, StringComparison.OrdinalIgnoreCase)).FirstOrDefault()) != null)
				{
					predicate.AppendFormat(" AND [{0}] = @{0}", propertyInfo.Name);
					parameters.Add(string.Format("@{0}", propertyInfo.Name), ChangeType(kvp.Value, propertyInfo.PropertyType));
				}
			}
			if (result.QueryParameters.Skip.HasValue ^ result.QueryParameters.Take.HasValue)
			{
				result.Ok = false;
				result.Error = "Skip and take must both have values if either is used";
				return result;
			}
			var predicateString = predicate.ToString();
			if (predicateString.Length > "WHERE 1 = 1 ".Length)
			{
				result.QueryParameters.Predicate = predicateString;
			}
			if (parameters.ParameterNames.Any())
			{
				result.QueryParameters.Parameters = parameters;
			}
			var orderByString = orderBy.ToString();
			orderByString = orderByString.TrimEnd(new char[] { ',' });
			if (orderByString.Length > "ORDER BY ".Length)
			{
				result.QueryParameters.Sort = orderByString;
			}
			return result;
		}

		private object ChangeType(string value, Type targetType)
		{
			if (targetType.IsGenericType && targetType.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				//this is questionable, but I couldn't find other way
				targetType = targetType.GenericTypeArguments[0];
			}
			if (targetType == typeof(DateTimeOffset))
			{
				return DateTimeOffset.Parse(value);
			}
			return Convert.ChangeType(value, targetType);
		}

    public QueryParserResult Parse<T>(Query query)
    {
      var result = new QueryParserResult {
        Ok = true
      };

      List<PropertyInfo> properties = typeof(T).GetProperties().ToList();
      result.Projections = GetProjections(properties, query?.Fields);
      var selectionPredicate = GetSelectionPredicate(properties, query.Filters);
      result.Predicate = selectionPredicate.predicate;
      result.Parameters = selectionPredicate.parameters;
      result.Sort = GetOrderByQuery(properties, query.Sort);
      result.Skip = query.Skip;
      result.Take = query.Take;
      return result;

    }
    public string GetProjections(List<PropertyInfo> properties, List<string> fields)
    {
      if (properties == null || properties?.Count == 0) {
        throw new ArgumentException("properties cannot be null or empty");
      }
      var propertieslist = properties.Select(x => x.Name).ToList();
      if (fields == null || fields?.Count == 0) {
        return null;
      }
      var fieldsNotInProperties = fields.Where(f => !propertieslist.Any(p => f.ToLower().Equals(p, StringComparison.OrdinalIgnoreCase))).ToList();
      if (fieldsNotInProperties?.Count > 0) {
        throw new ArgumentException("Provided Fileds Not Avaible in the Object Properties {0}", string.Join(",", fieldsNotInProperties));
      }
      return String.Format("[{0}]", string.Join("],[", fields));
    }

    public (string predicate, Dapper.DynamicParameters parameters) GetSelectionPredicate(List<PropertyInfo> properties, List<Filter> filters)
    {
      StringBuilder predicate = new StringBuilder("WHERE 1 = 1");
      Dapper.DynamicParameters parameters = new Dapper.DynamicParameters();

      if (properties == null || properties?.Count == 0) {
        throw new ArgumentException("properties cannot be null or empty");
      }
      if (filters == null || filters?.Count == 0) {
        return (string.Empty, null);
      }
      var filterOpertaorsNull = filters.Where(f => String.IsNullOrEmpty(f.FilterOperator)).ToList();
      if (filterOpertaorsNull != null && filterOpertaorsNull?.Count > 0) {
        throw new ArgumentNullException("null operators specified");
      }
      var FilterOperatorsNotRecognised = filters.Where(f => !FilterOperator.GetRecognisedOperators().Any(o => o.Equals(f.FilterOperator, StringComparison.OrdinalIgnoreCase)))
                                                .Select(x => x.FilterOperator)
                                                .ToList();
      if (FilterOperatorsNotRecognised != null && FilterOperatorsNotRecognised.Count > 0) {
        throw new ArgumentException("FilterOperators Not Recognised {0}", string.Join(",", FilterOperatorsNotRecognised));
      }
      var filtersKeysInvalid = filters.Where(f => !properties.Any(p => f.Key.ToLower().Equals(p.Name, StringComparison.OrdinalIgnoreCase)))
                                      .Select(x => x.Key)
                                      .ToList();
      if (filtersKeysInvalid?.Count > 0) {
        throw new ArgumentException("Provided Filter Keys Not Avaible in the Object Properties {0}", string.Join(",", filtersKeysInvalid));
      }

      foreach (var filter in filters) {
        var property = properties.Where(p => filter.Key.ToLower().Equals(p.Name, StringComparison.OrdinalIgnoreCase))
                             .SingleOrDefault();
        switch (filter.FilterOperator) {
          case FilterOperator.EQUALS:
            predicate.AppendFormat(" AND [{0}] = @{0}", property.Name);
            break;
          case FilterOperator.NOT_EQUALS:
            predicate.AppendFormat(" AND [{0}] != @{0}", property.Name);
            break;
          case FilterOperator.GREATERTHAN:
            predicate.AppendFormat(" AND [{0}] > @{0}", property.Name);
            break;
          case FilterOperator.GREATERTHAN_OR_EQUAL:
            predicate.AppendFormat(" AND [{0}] >= @{0}", property.Name);
            break;
          case FilterOperator.LESSTHAN:
            predicate.AppendFormat(" AND [{0}] < @{0}", property.Name);
            break;
          case FilterOperator.LESSTHAN_OR_EQUAL:
            predicate.AppendFormat(" AND [{0}] <= @{0}", property.Name);
            break;
          case FilterOperator.WILDCARD:
            predicate.AppendFormat(" AND [{0}] like @{0}", property.Name);
            break;
        }
        parameters.Add(string.Format("@{0}", property.Name), ChangeType(filter.Value, property.PropertyType));
      }
      var predicateString = predicate.ToString();
      return ((predicateString.Length > "WHERE 1 = 1 ".Length) ? predicateString : string.Empty, parameters);
    }

    public string GetOrderByQuery(List<PropertyInfo> properties, List<string> sortfields)
    {
      if (properties == null || properties?.Count == 0) {
        throw new ArgumentException("properties cannot be null or empty");
      }
      string DEFAULT_SORT = "ORDER BY [SysLastModified] DESC";
      if (sortfields == null || sortfields?.Count == 0) {
        return DEFAULT_SORT;
      }
      var sortFieldsNotRecognised = sortfields.Where(f => !properties.Any(p => p.Name.Equals(f.TrimStart(new char[] { '-' }), StringComparison.OrdinalIgnoreCase))).ToList();
      if (sortFieldsNotRecognised != null && sortFieldsNotRecognised.Count > 0) {
        throw new ArgumentException("SortFields Not Valid {0}", string.Join(",", sortFieldsNotRecognised));
      }
      StringBuilder orderBy = new StringBuilder("ORDER BY ");
      List<string> modifiedfileds = new List<string>();
      foreach (var field in sortfields) {
        var prop = properties.Where(p => p.Name.Equals(field.TrimStart(new char[] { '-' }), StringComparison.OrdinalIgnoreCase))
                             .Select(p => p.Name)
                             .SingleOrDefault();
        switch (field) {
          case string s when s.Trim().StartsWith("-"):
            modifiedfileds.Add("[" + prop + "] DESC");
            break;
          default:
            modifiedfileds.Add("[" + prop + "]");
            break;
        }
      }
      return orderBy.Append(String.Join(", ", modifiedfileds)).ToString();
    }

    public string GetSkipTakeQuery(int? skip, int? take)
    {
      string SKIP_TAKE_FORMAT = "OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY";
      if (take != null && take > 0) {
        if (skip != null && skip >= 0) {
          return String.Format(SKIP_TAKE_FORMAT, skip, take);
        }
      }

      return string.Empty;
    }
  }
}

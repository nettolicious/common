using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace Nettolicious.Common.Data
{
	public class QueryParserResult
	{
		public bool Ok { get; set; }
		public string Error { get; set; }

    [System.Obsolete("QueryParameters is deprecated, please use individual properties in the QueryParserResult instead.")]
    public QueryParameters QueryParameters { get; set; }

    /// <summary>
    /// SQL Projection SELECT " [Id],[Name] " FROM table
    /// Example : " [Id],[Name] "
    /// </summary>
    public string Projections { get; set; }

    /// <summary>
    /// SQL WHERE clause including the where keyword
    /// Example: "WHERE [Status] = 'Red'
    /// </summary>
    public string Predicate { get; set; }

    /// <summary>
    /// Dynamic parameters to be used by SQL WHERE clause
    /// </summary>
    public DynamicParameters Parameters { get; set; }

    /// <summary>
    /// SQL ORDER BY clause including the order by keywords
    /// Example: "ORDER BY [SysLastModified] DESC"
    /// </summary>
    public string Sort { get; set; }

    /// <summary>
    /// Number of records to skip in result set
    /// </summary>
    public int? Skip { get; set; }

    /// <summary>
    /// Number of records to take(limit) when executing a query
    /// </summary>
    public int? Take { get; set; }

    /// <summary>
    /// True if Skip and Take have values
    /// </summary>
    public bool SkipTake {
      get {
        return Skip.HasValue && Take.HasValue;
      }
    }
  }
}

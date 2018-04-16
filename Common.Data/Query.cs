using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nettolicious.Common.Data
{
  public class Query
  {
    /// <summary>
    /// Filter to be used in constructing SQL WHERE clause
    /// </summary>
    public List<Filter> Filters { get; set; }

    /// <summary>
    /// only these Fileds will be retrieved if this array is not null or empty, other wise all fileds will be retrieved
    /// </summary>
    public List<string> Fields { get; set; }

    /// <summary>
    /// SQL ORDER BY clause including the order by keywords
    /// Example: "ORDER BY [SysLastModified] DESC"
    /// </summary>
    public List<string> Sort { get; set; }

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

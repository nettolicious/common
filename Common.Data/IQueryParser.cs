using Dapper;
using System.Collections.Generic;

namespace Nettolicious.Common.Data
{
  public interface IQueryParser
  {
    QueryParserResult Parse<T>(IDictionary<string, string> queryParams);

    QueryParserResult Parse<T>(Query query);
  }
}
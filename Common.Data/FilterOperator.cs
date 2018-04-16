using System;
using System.Collections.Generic;
using System.Text;

namespace Nettolicious.Common.Data
{
  public static class FilterOperator
  {
    public const string WILDCARD = "wc";
    public const string GREATERTHAN = "gt";
    public const string LESSTHAN = "lt";
    public const string GREATERTHAN_OR_EQUAL = "ge";
    public const string LESSTHAN_OR_EQUAL = "le";
    public const string EQUALS = "eq";
    public const string NOT_EQUALS = "ne";
    public static List<string> GetRecognisedOperators()
    {
      var recognisedOperatorList = new List<string>() {
        FilterOperator.WILDCARD,
        FilterOperator.GREATERTHAN,
        FilterOperator.LESSTHAN,
        FilterOperator.GREATERTHAN_OR_EQUAL,
        FilterOperator.LESSTHAN_OR_EQUAL,
        FilterOperator.EQUALS,
        FilterOperator.NOT_EQUALS
      };
      return recognisedOperatorList;
    }
  }
}

using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Nettolicious.Common.AspNetCore.Extensions
{
	public static class QueryExtensions
	{
		public static Dictionary<string, string> ToDictionary(this IQueryCollection queryCollection)
		{
			var queryItems = new Dictionary<string, string>();
			foreach (var q in queryCollection)
			{
				queryItems.Add(q.Key, q.Value[0]);
			}
			return queryItems;
		}
	}
}

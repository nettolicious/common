using System;

namespace Nettolicious.Common.Extensions
{
	public static class StringExtensions
	{
		public static string AppendRelativeUrl(this string baseUrl, string relativeUrl)
		{
			if (relativeUrl == null)
			{
				relativeUrl = "";
			}
			return string.Format("{0}/{1}", baseUrl.TrimEnd('/'), relativeUrl.TrimStart('/'));
		}
	}
}

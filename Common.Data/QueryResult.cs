using System;
using System.Collections.Generic;
using System.Text;

namespace Nettolicious.Common.Data
{
	public class QueryResult<T>
	{
		/// <summary>
		/// Query time milliseconds
		/// </summary>
		public long QTime { get; set; }
		
		/// <summary>
		/// Total number of results found
		/// </summary>
		public long NumFound { get; set; }

		/// <summary>
		/// Zero-based start index, when using skip-take
		/// </summary>
		public long Start { get; set; }

		/// <summary>
		/// Result records
		/// </summary>
		public IEnumerable<T> Docs { get; set; }
	}
}

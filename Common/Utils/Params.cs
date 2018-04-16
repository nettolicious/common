using System;
using System.Collections.Generic;
using System.Text;

namespace Nettolicious.Common.Utils
{
	public static class Params
	{
		public static void Require(object param, string name)
		{
			if (param == null)
			{
				throw new ArgumentNullException(name);
			}
		}

		public static void Require(int param, string name, int min = 1)
		{
			if (param < min)
			{
				throw new ArgumentOutOfRangeException(string.Format("Int32 value was less than {0}.", min), name);
			}
		}

		public static void Require(long param, string name, long min = 1)
		{
			if (param < min)
			{
				throw new ArgumentOutOfRangeException(string.Format("Int64 value was less than {0}.", min), name);
			}
		}

		public static void Require(string param, string name)
		{
			if (String.IsNullOrWhiteSpace(param))
			{
				throw new ArgumentException("String was null or whitespace.", "param");
			}
		}
	}
}

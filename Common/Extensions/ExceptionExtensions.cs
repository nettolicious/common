using System;
using System.Text;
using System.Threading;

namespace Nettolicious.Common.Extensions
{
	public static class ExceptionExtensions
	{
		public static string ToStringVerbose(this Exception ex)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(String.Format("Exception message: {0}", ex.Message));
			sb.AppendLine(String.Format("Stack trace: {0}", ex.StackTrace));
			var innerException = ex.InnerException;
			while (innerException != null)
			{
				sb.AppendLine(String.Format("Exception message: {0}", innerException.Message));
				sb.AppendLine(String.Format("Stack trace: {0}", innerException.StackTrace));
				innerException = innerException.InnerException;
			}
			return sb.ToString();
		}

		public static bool IsCritical(this Exception ex)
		{
			if (ex is NullReferenceException || ex is OutOfMemoryException || ex is StackOverflowException || ex is AccessViolationException || ex is ThreadAbortException
										|| ex is IndexOutOfRangeException)
			{
				return true;
			}
			return false;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using Nettolicious.Common.Logging;

namespace Nettolicious.ValuesLib
{
	public class ValuesService : IValuesService
	{
		private ILogger mLogger;

		public ValuesService(ILogger logger = null)
		{
			mLogger = logger ?? new NullLogger();
		}

		public string[] Get()
		{
			mLogger.Debug("Returning values value3 and value4");
			return new string[] { "value3", "value4" };
		}

		public string Get(int id)
		{
			mLogger.Debug("Returning value value");
			return "value";
		}
	}
}

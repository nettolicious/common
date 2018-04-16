using System;
using System.Collections.Generic;
using System.Text;

namespace Nettolicious.Common.Providers
{
	public class SettingsProvider : ISettingsProvider
	{
		public IDictionary<string,string> Settings { get; private set; }

		public bool TryGetSetting(string key, out string value)
		{
			if (String.IsNullOrWhiteSpace(key))
			{
				throw new ArgumentException("String was null or whitespace.", "key");
			}
			return Settings.TryGetValue(key, out value);
		}

		public SettingsProvider(IDictionary<string,string> settings)
		{
			Settings = settings ?? throw new ArgumentNullException("settings");
		}
	}
}

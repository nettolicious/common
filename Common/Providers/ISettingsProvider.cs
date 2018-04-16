using System.Collections.Generic;

namespace Nettolicious.Common.Providers
{
	public interface ISettingsProvider
	{
		IDictionary<string, string> Settings { get; }
		bool TryGetSetting(string key, out string value);
	}
}
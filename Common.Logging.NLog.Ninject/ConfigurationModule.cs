using Ninject.Modules;
using System.Linq;

namespace Nettolicious.Common.Logging.NLog.Ninject
{
	public class ConfigurationModule : NinjectModule
	{
		public static INinjectModule[] GetModules()
		{
			return new INinjectModule[]
			{
				new ConfigurationModule()
			};
		}

		public override void Load()
		{
			if (!Kernel.GetBindings(typeof(global::NLog.ILogger)).Any())
			{
				Bind<global::NLog.ILogger>().ToMethod(x => global::NLog.LogManager.GetLogger(x.Request.ParentContext.Request.Service.FullName));
			}
			if (!Kernel.GetBindings(typeof(ILogger)).Any())
			{
				Bind<ILogger>().To<Logger>();
			}
		}
	}
}

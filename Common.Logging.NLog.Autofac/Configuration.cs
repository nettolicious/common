using Autofac;
using ATF = Autofac;

namespace Nettolicious.Common.Logging.NLog.Autofac
{
	public class Configuration : ATF.Module
	{
		protected override void Load(ATF.ContainerBuilder builder)
		{
			builder.RegisterModule(new NLogConfiguration());
			builder.RegisterModule(new SimpleNLogConfiguration());
		}
	}
}

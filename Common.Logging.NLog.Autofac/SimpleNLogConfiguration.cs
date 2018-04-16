using Autofac; //Included for Register extension method
using ATF = Autofac;
using NLG = NLog;

namespace Nettolicious.Common.Logging.NLog.Autofac
{
	public class SimpleNLogConfiguration : ATF.Module
	{
		protected override void Load(ATF.ContainerBuilder builder)
		{
			builder
					.Register(context => new Nettolicious.Common.Logging.NLog.Logger(NLG.LogManager.GetCurrentClassLogger()))
					.As<Nettolicious.Common.Logging.ILogger>()
					.SingleInstance();
		}
	}
}

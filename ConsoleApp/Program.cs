using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nettolicious.Common.Logging;
using Nettolicious.Common.Logging.NLog;
using Nettolicious.ValuesLib;
using Autofac;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Starting...");

			ILogger logger = new Logger(NLog.LogManager.GetCurrentClassLogger());
			logger.Debug("Test message");

			IValuesService values = new ValuesService();
			values.Get();

			values = new ValuesService(logger);
			values.Get();

			var builder = new ContainerBuilder();
			builder.Register(c => NLog.LogManager.GetCurrentClassLogger()).As<NLog.ILogger>();
			builder.RegisterType<Logger>().As<ILogger>();
			builder.RegisterType<ValuesService>().As<IValuesService>();
			var container = builder.Build();

			values = container.Resolve<IValuesService>();
			values.Get(5);

			builder = new ContainerBuilder();
			builder.RegisterType<ValuesService>().As<IValuesService>();
			container = builder.Build();

			Console.WriteLine("Nothing should be logged after this");
			values = container.Resolve<IValuesService>();
			values.Get();

			Console.WriteLine("Ending...");
			Console.ReadLine();

			//TODO
			//https://stackoverflow.com/questions/28443955/how-to-inject-nlog-using-autofac-in-asp-net-webforms
		}
	}
}

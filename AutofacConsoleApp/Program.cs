using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Nettolicious.ValuesLib;

namespace AutofacConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Starting...");

			//Logger configured with Autofac
			var builder = new ContainerBuilder();
			builder.RegisterModule(new Nettolicious.Common.Logging.NLog.Autofac.Configuration());
			builder.RegisterType<ValuesService>().As<IValuesService>();
			var container = builder.Build();

			var values = container.Resolve<IValuesService>();
			values.Get(5);

			//No logger configured but getting IValuesService from Autofac
			builder = new ContainerBuilder();
			builder.RegisterType<ValuesService>().As<IValuesService>();
			container = builder.Build();

			Console.WriteLine("Nothing should be logged after this");
			values = container.Resolve<IValuesService>();
			values.Get();

			//No logger and no DI
			values = new ValuesService();
			values.Get();

			Console.WriteLine("Ending...");
			Console.ReadLine();
		}
	}
}

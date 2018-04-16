using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Nettolicious.Common.Data.Autofac
{
	public class Configuration : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<QueryParser>().As<IQueryParser>();
		}
	}
}

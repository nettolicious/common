using System.Linq;
using System.Reflection;
using ATF = Autofac;
using ATFC = Autofac.Core;
using NLG = NLog;

namespace Nettolicious.Common.Logging.NLog.Autofac
{
	public class NLogConfiguration : ATF.Module
	{
		private static void InjectLoggerProperties(object instance)
		{
			var instanceType = instance.GetType();

			// Get all the injectable properties to set.
			// If you wanted to ensure the properties were only UNSET properties,
			// here's where you'd do it.
			var properties = instanceType
				.GetProperties(BindingFlags.Public | BindingFlags.Instance)
				.Where(p => p.PropertyType == typeof(Nettolicious.Common.Logging.ILogger) && p.CanWrite && p.GetIndexParameters().Length == 0);

			// Set the properties located.
			foreach (var propToSet in properties)
			{
				propToSet.SetValue(instance, new Nettolicious.Common.Logging.NLog.Logger(NLG.LogManager.GetLogger(instanceType.FullName)), null);
			}
		}

		private static void OnComponentPreparing(object sender, ATFC.PreparingEventArgs e)
		{
			e.Parameters = e.Parameters.Union(
					new[]
					{
						new ATFC.ResolvedParameter(
							(p, i) => p.ParameterType == typeof(Nettolicious.Common.Logging.ILogger),
							(p, i) => new Nettolicious.Common.Logging.NLog.Logger(NLG.LogManager.GetLogger(p.Member.DeclaringType.FullName)))
					});
		}

		protected override void AttachToComponentRegistration(ATFC.IComponentRegistry componentRegistry, ATFC.IComponentRegistration registration)
		{
			// Handle constructor parameters.
			registration.Preparing += OnComponentPreparing;

			// Handle properties.
			registration.Activated += (sender, e) => InjectLoggerProperties(e.Instance);
		}
	}
}

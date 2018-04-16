using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.IO;

namespace GenLoggerClass
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Starting...");

			var type = typeof(ILogger);
			var methods = type.GetMethods().ToList().Where(x => !x.Name.Substring(0, 4).Equals("get_")).OrderBy(x => x.Name).ToList();

			using (var file = new StreamWriter("out.txt"))
			{
				foreach (var method in methods)
				{
					bool skip = false;
					StringBuilder methodText = new StringBuilder();
					StringBuilder genericParamsText = new StringBuilder();
					StringBuilder sigParamsText = new StringBuilder();
					StringBuilder callParamsText = new StringBuilder();
					var _params = method.GetParameters();
					foreach (var _param in _params)
					{
						if (_param.ParameterType.Name.Equals("LogMessageGenerator"))
						{
							skip = true;
							break;
						}
						if (_param.ParameterType.IsGenericParameter)
						{
							genericParamsText.AppendFormat("{0},", _param.ParameterType.Name);
						}
						sigParamsText.AppendFormat("{0} {1}, ", _param.ParameterType.Name, _param.Name);
						callParamsText.AppendFormat("{0}, ", _param.Name);
					}
					if (skip)
					{
						continue;
					}
					var genericParams = genericParamsText.ToString();
					var sigParams = sigParamsText.ToString();
					var callParams = callParamsText.ToString();
					if (genericParams.Length > 0)
					{
						genericParams = genericParams.Substring(0, genericParams.Length - 1);
					}
					if (sigParams.Length > 0)
					{
						sigParams = sigParams.Substring(0, sigParams.Length - 2);
						callParams = callParams.Substring(0, callParams.Length - 2);
					}
					if (method.GetCustomAttributes(false).ToList().OfType<ObsoleteAttribute>().Any())
					{
						var message = method.GetCustomAttributes(false).ToList().OfType<ObsoleteAttribute>().First().Message;
						methodText.AppendFormat("[Obsolete(\"{0}\")]\n", message);
					}
					methodText.AppendFormat("public void {0}", method.Name);
					if (method.ContainsGenericParameters)
					{
						methodText.AppendFormat("<{0}>", genericParams);
					}
					methodText.Append("(");
					methodText.Append(sigParams);
					methodText.AppendLine(") {");
					methodText.AppendFormat("  mLogger.{0}({1});\n", method.Name, callParams);
					methodText.AppendLine("}");
					Console.WriteLine(methodText.ToString());
					file.Write(methodText);
				}
			}

			Console.WriteLine("Ending...");
			Console.Read();
		}
	}
}

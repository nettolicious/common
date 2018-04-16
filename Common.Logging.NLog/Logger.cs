using System;
using System.Collections.Generic;
using System.Text;
using Nettolicious.Common.Logging;

namespace Nettolicious.Common.Logging.NLog
{
	public class Logger : ILogger
	{
		private global::NLog.ILogger mLogger;

		public Logger(global::NLog.ILogger logger)
		{
			mLogger = logger;
		}

		public bool IsFatalEnabled { get { return mLogger.IsFatalEnabled; } }

		public bool IsWarnEnabled { get { return mLogger.IsWarnEnabled; } }

		public bool IsInfoEnabled { get { return mLogger.IsInfoEnabled; } }

		public bool IsDebugEnabled { get { return mLogger.IsDebugEnabled; } }

		public bool IsTraceEnabled { get { return mLogger.IsTraceEnabled; } }

		public bool IsErrorEnabled { get { return mLogger.IsErrorEnabled; } }

		public void Debug<T>(T value)
		{
			mLogger.Debug(value);
		}
		public void Debug<T>(IFormatProvider formatProvider, T value)
		{
			mLogger.Debug(formatProvider, value);
		}
		public void Debug(Exception exception, String message)
		{
			mLogger.Debug(exception, message);
		}
		public void Debug(Exception exception, String message, Object[] args)
		{
			mLogger.Debug(exception, message, args);
		}
		public void Debug(Exception exception, IFormatProvider formatProvider, String message, Object[] args)
		{
			mLogger.Debug(exception, formatProvider, message, args);
		}
		public void Debug(IFormatProvider formatProvider, String message, Object[] args)
		{
			mLogger.Debug(formatProvider, message, args);
		}
		public void Debug(String message)
		{
			mLogger.Debug(message);
		}
		public void Debug(String message, Object[] args)
		{
			mLogger.Debug(message, args);
		}
		[Obsolete("Use Debug(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void Debug(String message, Exception exception)
		{
			mLogger.Debug(message, exception);
		}
		public void Debug<TArgument>(IFormatProvider formatProvider, String message, TArgument argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug<TArgument>(String message, TArgument argument)
		{
			mLogger.Debug(message, argument);
		}
		public void Debug<TArgument1, TArgument2>(IFormatProvider formatProvider, String message, TArgument1 argument1, TArgument2 argument2)
		{
			mLogger.Debug(formatProvider, message, argument1, argument2);
		}
		public void Debug<TArgument1, TArgument2>(String message, TArgument1 argument1, TArgument2 argument2)
		{
			mLogger.Debug(message, argument1, argument2);
		}
		public void Debug<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, String message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			mLogger.Debug(formatProvider, message, argument1, argument2, argument3);
		}
		public void Debug<TArgument1, TArgument2, TArgument3>(String message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			mLogger.Debug(message, argument1, argument2, argument3);
		}
		public void Debug(Object value)
		{
			mLogger.Debug(value);
		}
		public void Debug(IFormatProvider formatProvider, Object value)
		{
			mLogger.Debug(formatProvider, value);
		}
		public void Debug(String message, Object arg1, Object arg2)
		{
			mLogger.Debug(message, arg1, arg2);
		}
		public void Debug(String message, Object arg1, Object arg2, Object arg3)
		{
			mLogger.Debug(message, arg1, arg2, arg3);
		}
		public void Debug(IFormatProvider formatProvider, String message, Boolean argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug(String message, Boolean argument)
		{
			mLogger.Debug(message, argument);
		}
		public void Debug(IFormatProvider formatProvider, String message, Char argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug(String message, Char argument)
		{
			mLogger.Debug(message, argument);
		}
		public void Debug(IFormatProvider formatProvider, String message, Byte argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug(String message, Byte argument)
		{
			mLogger.Debug(message, argument);
		}
		public void Debug(IFormatProvider formatProvider, String message, String argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug(String message, String argument)
		{
			mLogger.Debug(message, argument);
		}
		public void Debug(IFormatProvider formatProvider, String message, Int32 argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug(String message, Int32 argument)
		{
			mLogger.Debug(message, argument);
		}
		public void Debug(IFormatProvider formatProvider, String message, Int64 argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug(String message, Int64 argument)
		{
			mLogger.Debug(message, argument);
		}
		public void Debug(IFormatProvider formatProvider, String message, Single argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug(String message, Single argument)
		{
			mLogger.Debug(message, argument);
		}
		public void Debug(IFormatProvider formatProvider, String message, Double argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug(String message, Double argument)
		{
			mLogger.Debug(message, argument);
		}
		public void Debug(IFormatProvider formatProvider, String message, Decimal argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug(String message, Decimal argument)
		{
			mLogger.Debug(message, argument);
		}
		public void Debug(IFormatProvider formatProvider, String message, Object argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug(String message, Object argument)
		{
			mLogger.Debug(message, argument);
		}
		public void Debug(IFormatProvider formatProvider, String message, SByte argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug(String message, SByte argument)
		{
			mLogger.Debug(message, argument);
		}
		public void Debug(IFormatProvider formatProvider, String message, UInt32 argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug(String message, UInt32 argument)
		{
			mLogger.Debug(message, argument);
		}
		public void Debug(IFormatProvider formatProvider, String message, UInt64 argument)
		{
			mLogger.Debug(formatProvider, message, argument);
		}
		public void Debug(String message, UInt64 argument)
		{
			mLogger.Debug(message, argument);
		}
		[Obsolete("Use Debug(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void DebugException(String message, Exception exception)
		{
			mLogger.DebugException(message, exception);
		}
		public void Error<T>(T value)
		{
			mLogger.Error(value);
		}
		public void Error<T>(IFormatProvider formatProvider, T value)
		{
			mLogger.Error(formatProvider, value);
		}
		public void Error(Exception exception, String message)
		{
			mLogger.Error(exception, message);
		}
		public void Error(Exception exception, String message, Object[] args)
		{
			mLogger.Error(exception, message, args);
		}
		public void Error(Exception exception, IFormatProvider formatProvider, String message, Object[] args)
		{
			mLogger.Error(exception, formatProvider, message, args);
		}
		public void Error(IFormatProvider formatProvider, String message, Object[] args)
		{
			mLogger.Error(formatProvider, message, args);
		}
		public void Error(String message)
		{
			mLogger.Error(message);
		}
		public void Error(String message, Object[] args)
		{
			mLogger.Error(message, args);
		}
		[Obsolete("Use Error(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void Error(String message, Exception exception)
		{
			mLogger.Error(message, exception);
		}
		public void Error<TArgument>(IFormatProvider formatProvider, String message, TArgument argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error<TArgument>(String message, TArgument argument)
		{
			mLogger.Error(message, argument);
		}
		public void Error<TArgument1, TArgument2>(IFormatProvider formatProvider, String message, TArgument1 argument1, TArgument2 argument2)
		{
			mLogger.Error(formatProvider, message, argument1, argument2);
		}
		public void Error<TArgument1, TArgument2>(String message, TArgument1 argument1, TArgument2 argument2)
		{
			mLogger.Error(message, argument1, argument2);
		}
		public void Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, String message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			mLogger.Error(formatProvider, message, argument1, argument2, argument3);
		}
		public void Error<TArgument1, TArgument2, TArgument3>(String message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			mLogger.Error(message, argument1, argument2, argument3);
		}
		public void Error(Object value)
		{
			mLogger.Error(value);
		}
		public void Error(IFormatProvider formatProvider, Object value)
		{
			mLogger.Error(formatProvider, value);
		}
		public void Error(String message, Object arg1, Object arg2)
		{
			mLogger.Error(message, arg1, arg2);
		}
		public void Error(String message, Object arg1, Object arg2, Object arg3)
		{
			mLogger.Error(message, arg1, arg2, arg3);
		}
		public void Error(IFormatProvider formatProvider, String message, Boolean argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error(String message, Boolean argument)
		{
			mLogger.Error(message, argument);
		}
		public void Error(IFormatProvider formatProvider, String message, Char argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error(String message, Char argument)
		{
			mLogger.Error(message, argument);
		}
		public void Error(IFormatProvider formatProvider, String message, Byte argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error(String message, Byte argument)
		{
			mLogger.Error(message, argument);
		}
		public void Error(IFormatProvider formatProvider, String message, String argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error(String message, String argument)
		{
			mLogger.Error(message, argument);
		}
		public void Error(IFormatProvider formatProvider, String message, Int32 argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error(String message, Int32 argument)
		{
			mLogger.Error(message, argument);
		}
		public void Error(IFormatProvider formatProvider, String message, Int64 argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error(String message, Int64 argument)
		{
			mLogger.Error(message, argument);
		}
		public void Error(IFormatProvider formatProvider, String message, Single argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error(String message, Single argument)
		{
			mLogger.Error(message, argument);
		}
		public void Error(IFormatProvider formatProvider, String message, Double argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error(String message, Double argument)
		{
			mLogger.Error(message, argument);
		}
		public void Error(IFormatProvider formatProvider, String message, Decimal argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error(String message, Decimal argument)
		{
			mLogger.Error(message, argument);
		}
		public void Error(IFormatProvider formatProvider, String message, Object argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error(String message, Object argument)
		{
			mLogger.Error(message, argument);
		}
		public void Error(IFormatProvider formatProvider, String message, SByte argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error(String message, SByte argument)
		{
			mLogger.Error(message, argument);
		}
		public void Error(IFormatProvider formatProvider, String message, UInt32 argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error(String message, UInt32 argument)
		{
			mLogger.Error(message, argument);
		}
		public void Error(IFormatProvider formatProvider, String message, UInt64 argument)
		{
			mLogger.Error(formatProvider, message, argument);
		}
		public void Error(String message, UInt64 argument)
		{
			mLogger.Error(message, argument);
		}
		[Obsolete("Use Error(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void ErrorException(String message, Exception exception)
		{
			mLogger.ErrorException(message, exception);
		}
		public void Fatal<T>(T value)
		{
			mLogger.Fatal(value);
		}
		public void Fatal<T>(IFormatProvider formatProvider, T value)
		{
			mLogger.Fatal(formatProvider, value);
		}
		public void Fatal(Exception exception, String message)
		{
			mLogger.Fatal(exception, message);
		}
		public void Fatal(Exception exception, String message, Object[] args)
		{
			mLogger.Fatal(exception, message, args);
		}
		public void Fatal(Exception exception, IFormatProvider formatProvider, String message, Object[] args)
		{
			mLogger.Fatal(exception, formatProvider, message, args);
		}
		public void Fatal(IFormatProvider formatProvider, String message, Object[] args)
		{
			mLogger.Fatal(formatProvider, message, args);
		}
		public void Fatal(String message)
		{
			mLogger.Fatal(message);
		}
		public void Fatal(String message, Object[] args)
		{
			mLogger.Fatal(message, args);
		}
		[Obsolete("Use Fatal(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void Fatal(String message, Exception exception)
		{
			mLogger.Fatal(message, exception);
		}
		public void Fatal<TArgument>(IFormatProvider formatProvider, String message, TArgument argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal<TArgument>(String message, TArgument argument)
		{
			mLogger.Fatal(message, argument);
		}
		public void Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider, String message, TArgument1 argument1, TArgument2 argument2)
		{
			mLogger.Fatal(formatProvider, message, argument1, argument2);
		}
		public void Fatal<TArgument1, TArgument2>(String message, TArgument1 argument1, TArgument2 argument2)
		{
			mLogger.Fatal(message, argument1, argument2);
		}
		public void Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, String message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			mLogger.Fatal(formatProvider, message, argument1, argument2, argument3);
		}
		public void Fatal<TArgument1, TArgument2, TArgument3>(String message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			mLogger.Fatal(message, argument1, argument2, argument3);
		}
		public void Fatal(IFormatProvider formatProvider, String message, Decimal argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal(String message, Decimal argument)
		{
			mLogger.Fatal(message, argument);
		}
		public void Fatal(IFormatProvider formatProvider, String message, Object argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal(String message, Object argument)
		{
			mLogger.Fatal(message, argument);
		}
		public void Fatal(IFormatProvider formatProvider, String message, SByte argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal(String message, SByte argument)
		{
			mLogger.Fatal(message, argument);
		}
		public void Fatal(IFormatProvider formatProvider, String message, UInt32 argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal(String message, UInt32 argument)
		{
			mLogger.Fatal(message, argument);
		}
		public void Fatal(IFormatProvider formatProvider, String message, UInt64 argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal(String message, UInt64 argument)
		{
			mLogger.Fatal(message, argument);
		}
		public void Fatal(Object value)
		{
			mLogger.Fatal(value);
		}
		public void Fatal(IFormatProvider formatProvider, Object value)
		{
			mLogger.Fatal(formatProvider, value);
		}
		public void Fatal(String message, Object arg1, Object arg2)
		{
			mLogger.Fatal(message, arg1, arg2);
		}
		public void Fatal(String message, Object arg1, Object arg2, Object arg3)
		{
			mLogger.Fatal(message, arg1, arg2, arg3);
		}
		public void Fatal(IFormatProvider formatProvider, String message, Boolean argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal(String message, Boolean argument)
		{
			mLogger.Fatal(message, argument);
		}
		public void Fatal(IFormatProvider formatProvider, String message, Char argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal(String message, Char argument)
		{
			mLogger.Fatal(message, argument);
		}
		public void Fatal(IFormatProvider formatProvider, String message, Byte argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal(String message, Byte argument)
		{
			mLogger.Fatal(message, argument);
		}
		public void Fatal(IFormatProvider formatProvider, String message, String argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal(String message, String argument)
		{
			mLogger.Fatal(message, argument);
		}
		public void Fatal(IFormatProvider formatProvider, String message, Int32 argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal(String message, Int32 argument)
		{
			mLogger.Fatal(message, argument);
		}
		public void Fatal(IFormatProvider formatProvider, String message, Int64 argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal(String message, Int64 argument)
		{
			mLogger.Fatal(message, argument);
		}
		public void Fatal(IFormatProvider formatProvider, String message, Single argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal(String message, Single argument)
		{
			mLogger.Fatal(message, argument);
		}
		public void Fatal(IFormatProvider formatProvider, String message, Double argument)
		{
			mLogger.Fatal(formatProvider, message, argument);
		}
		public void Fatal(String message, Double argument)
		{
			mLogger.Fatal(message, argument);
		}
		[Obsolete("Use Fatal(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void FatalException(String message, Exception exception)
		{
			mLogger.FatalException(message, exception);
		}
		public void Info<T>(T value)
		{
			mLogger.Info(value);
		}
		public void Info<T>(IFormatProvider formatProvider, T value)
		{
			mLogger.Info(formatProvider, value);
		}
		public void Info(Exception exception, String message)
		{
			mLogger.Info(exception, message);
		}
		public void Info(Exception exception, String message, Object[] args)
		{
			mLogger.Info(exception, message, args);
		}
		public void Info(Exception exception, IFormatProvider formatProvider, String message, Object[] args)
		{
			mLogger.Info(exception, formatProvider, message, args);
		}
		public void Info(IFormatProvider formatProvider, String message, Object[] args)
		{
			mLogger.Info(formatProvider, message, args);
		}
		public void Info(String message)
		{
			mLogger.Info(message);
		}
		public void Info(String message, Object[] args)
		{
			mLogger.Info(message, args);
		}
		[Obsolete("Use Info(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void Info(String message, Exception exception)
		{
			mLogger.Info(message, exception);
		}
		public void Info<TArgument>(IFormatProvider formatProvider, String message, TArgument argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		public void Info<TArgument>(String message, TArgument argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info<TArgument1, TArgument2>(IFormatProvider formatProvider, String message, TArgument1 argument1, TArgument2 argument2)
		{
			mLogger.Info(formatProvider, message, argument1, argument2);
		}
		public void Info<TArgument1, TArgument2>(String message, TArgument1 argument1, TArgument2 argument2)
		{
			mLogger.Info(message, argument1, argument2);
		}
		public void Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, String message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			mLogger.Info(formatProvider, message, argument1, argument2, argument3);
		}
		public void Info<TArgument1, TArgument2, TArgument3>(String message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			mLogger.Info(message, argument1, argument2, argument3);
		}
		public void Info(String message, SByte argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info(IFormatProvider formatProvider, String message, UInt32 argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		public void Info(String message, UInt32 argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info(IFormatProvider formatProvider, String message, UInt64 argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		public void Info(String message, UInt64 argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info(Object value)
		{
			mLogger.Info(value);
		}
		public void Info(IFormatProvider formatProvider, Object value)
		{
			mLogger.Info(formatProvider, value);
		}
		public void Info(String message, Object arg1, Object arg2)
		{
			mLogger.Info(message, arg1, arg2);
		}
		public void Info(String message, Object arg1, Object arg2, Object arg3)
		{
			mLogger.Info(message, arg1, arg2, arg3);
		}
		public void Info(IFormatProvider formatProvider, String message, Boolean argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		public void Info(String message, Boolean argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info(IFormatProvider formatProvider, String message, Char argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		public void Info(String message, Char argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info(IFormatProvider formatProvider, String message, Byte argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		public void Info(String message, Byte argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info(IFormatProvider formatProvider, String message, String argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		public void Info(String message, String argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info(IFormatProvider formatProvider, String message, Int32 argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		public void Info(String message, Int32 argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info(IFormatProvider formatProvider, String message, Int64 argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		public void Info(String message, Int64 argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info(IFormatProvider formatProvider, String message, Single argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		public void Info(String message, Single argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info(IFormatProvider formatProvider, String message, Double argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		public void Info(String message, Double argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info(IFormatProvider formatProvider, String message, Decimal argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		public void Info(String message, Decimal argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info(IFormatProvider formatProvider, String message, Object argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		public void Info(String message, Object argument)
		{
			mLogger.Info(message, argument);
		}
		public void Info(IFormatProvider formatProvider, String message, SByte argument)
		{
			mLogger.Info(formatProvider, message, argument);
		}
		[Obsolete("Use Info(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void InfoException(String message, Exception exception)
		{
			mLogger.InfoException(message, exception);
		}
		public void Trace<T>(T value)
		{
			mLogger.Trace(value);
		}
		public void Trace<T>(IFormatProvider formatProvider, T value)
		{
			mLogger.Trace(formatProvider, value);
		}
		public void Trace(Exception exception, String message)
		{
			mLogger.Trace(exception, message);
		}
		public void Trace(Exception exception, String message, Object[] args)
		{
			mLogger.Trace(exception, message, args);
		}
		public void Trace(Exception exception, IFormatProvider formatProvider, String message, Object[] args)
		{
			mLogger.Trace(exception, formatProvider, message, args);
		}
		public void Trace(IFormatProvider formatProvider, String message, Object[] args)
		{
			mLogger.Trace(formatProvider, message, args);
		}
		public void Trace(String message)
		{
			mLogger.Trace(message);
		}
		public void Trace(String message, Object[] args)
		{
			mLogger.Trace(message, args);
		}
		[Obsolete("Use Trace(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void Trace(String message, Exception exception)
		{
			mLogger.Trace(message, exception);
		}
		public void Trace<TArgument>(IFormatProvider formatProvider, String message, TArgument argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace<TArgument>(String message, TArgument argument)
		{
			mLogger.Trace(message, argument);
		}
		public void Trace<TArgument1, TArgument2>(IFormatProvider formatProvider, String message, TArgument1 argument1, TArgument2 argument2)
		{
			mLogger.Trace(formatProvider, message, argument1, argument2);
		}
		public void Trace<TArgument1, TArgument2>(String message, TArgument1 argument1, TArgument2 argument2)
		{
			mLogger.Trace(message, argument1, argument2);
		}
		public void Trace<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, String message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			mLogger.Trace(formatProvider, message, argument1, argument2, argument3);
		}
		public void Trace<TArgument1, TArgument2, TArgument3>(String message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			mLogger.Trace(message, argument1, argument2, argument3);
		}
		public void Trace(Object value)
		{
			mLogger.Trace(value);
		}
		public void Trace(IFormatProvider formatProvider, Object value)
		{
			mLogger.Trace(formatProvider, value);
		}
		public void Trace(String message, Object arg1, Object arg2)
		{
			mLogger.Trace(message, arg1, arg2);
		}
		public void Trace(String message, Object arg1, Object arg2, Object arg3)
		{
			mLogger.Trace(message, arg1, arg2, arg3);
		}
		public void Trace(IFormatProvider formatProvider, String message, Boolean argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace(String message, Boolean argument)
		{
			mLogger.Trace(message, argument);
		}
		public void Trace(IFormatProvider formatProvider, String message, Char argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace(String message, Char argument)
		{
			mLogger.Trace(message, argument);
		}
		public void Trace(IFormatProvider formatProvider, String message, Byte argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace(String message, Byte argument)
		{
			mLogger.Trace(message, argument);
		}
		public void Trace(IFormatProvider formatProvider, String message, String argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace(String message, String argument)
		{
			mLogger.Trace(message, argument);
		}
		public void Trace(IFormatProvider formatProvider, String message, Int32 argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace(String message, Int32 argument)
		{
			mLogger.Trace(message, argument);
		}
		public void Trace(IFormatProvider formatProvider, String message, Int64 argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace(String message, Int64 argument)
		{
			mLogger.Trace(message, argument);
		}
		public void Trace(IFormatProvider formatProvider, String message, Single argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace(String message, Single argument)
		{
			mLogger.Trace(message, argument);
		}
		public void Trace(IFormatProvider formatProvider, String message, Double argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace(String message, Double argument)
		{
			mLogger.Trace(message, argument);
		}
		public void Trace(IFormatProvider formatProvider, String message, Decimal argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace(String message, Decimal argument)
		{
			mLogger.Trace(message, argument);
		}
		public void Trace(IFormatProvider formatProvider, String message, Object argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace(String message, Object argument)
		{
			mLogger.Trace(message, argument);
		}
		public void Trace(IFormatProvider formatProvider, String message, SByte argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace(String message, SByte argument)
		{
			mLogger.Trace(message, argument);
		}
		public void Trace(IFormatProvider formatProvider, String message, UInt32 argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace(String message, UInt32 argument)
		{
			mLogger.Trace(message, argument);
		}
		public void Trace(IFormatProvider formatProvider, String message, UInt64 argument)
		{
			mLogger.Trace(formatProvider, message, argument);
		}
		public void Trace(String message, UInt64 argument)
		{
			mLogger.Trace(message, argument);
		}
		[Obsolete("Use Trace(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void TraceException(String message, Exception exception)
		{
			mLogger.TraceException(message, exception);
		}
		public void Warn<T>(IFormatProvider formatProvider, T value)
		{
			mLogger.Warn(formatProvider, value);
		}
		public void Warn(Exception exception, String message)
		{
			mLogger.Warn(exception, message);
		}
		public void Warn(Exception exception, String message, Object[] args)
		{
			mLogger.Warn(exception, message, args);
		}
		public void Warn(Exception exception, IFormatProvider formatProvider, String message, Object[] args)
		{
			mLogger.Warn(exception, formatProvider, message, args);
		}
		public void Warn(IFormatProvider formatProvider, String message, Object[] args)
		{
			mLogger.Warn(formatProvider, message, args);
		}
		public void Warn(String message)
		{
			mLogger.Warn(message);
		}
		public void Warn(String message, Object[] args)
		{
			mLogger.Warn(message, args);
		}
		[Obsolete("Use Warn(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void Warn(String message, Exception exception)
		{
			mLogger.Warn(message, exception);
		}
		public void Warn<TArgument>(IFormatProvider formatProvider, String message, TArgument argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn<TArgument>(String message, TArgument argument)
		{
			mLogger.Warn(message, argument);
		}
		public void Warn<TArgument1, TArgument2>(IFormatProvider formatProvider, String message, TArgument1 argument1, TArgument2 argument2)
		{
			mLogger.Warn(formatProvider, message, argument1, argument2);
		}
		public void Warn<TArgument1, TArgument2>(String message, TArgument1 argument1, TArgument2 argument2)
		{
			mLogger.Warn(message, argument1, argument2);
		}
		public void Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, String message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			mLogger.Warn(formatProvider, message, argument1, argument2, argument3);
		}
		public void Warn<TArgument1, TArgument2, TArgument3>(String message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
		{
			mLogger.Warn(message, argument1, argument2, argument3);
		}
		public void Warn<T>(T value)
		{
			mLogger.Warn(value);
		}
		public void Warn(Object value)
		{
			mLogger.Warn(value);
		}
		public void Warn(IFormatProvider formatProvider, Object value)
		{
			mLogger.Warn(formatProvider, value);
		}
		public void Warn(String message, Object arg1, Object arg2)
		{
			mLogger.Warn(message, arg1, arg2);
		}
		public void Warn(String message, Object arg1, Object arg2, Object arg3)
		{
			mLogger.Warn(message, arg1, arg2, arg3);
		}
		public void Warn(IFormatProvider formatProvider, String message, Boolean argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn(String message, Boolean argument)
		{
			mLogger.Warn(message, argument);
		}
		public void Warn(IFormatProvider formatProvider, String message, Char argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn(String message, Char argument)
		{
			mLogger.Warn(message, argument);
		}
		public void Warn(IFormatProvider formatProvider, String message, Byte argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn(String message, Byte argument)
		{
			mLogger.Warn(message, argument);
		}
		public void Warn(IFormatProvider formatProvider, String message, String argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn(String message, String argument)
		{
			mLogger.Warn(message, argument);
		}
		public void Warn(IFormatProvider formatProvider, String message, Int32 argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn(String message, Int32 argument)
		{
			mLogger.Warn(message, argument);
		}
		public void Warn(IFormatProvider formatProvider, String message, Int64 argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn(String message, Int64 argument)
		{
			mLogger.Warn(message, argument);
		}
		public void Warn(IFormatProvider formatProvider, String message, Single argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn(String message, Single argument)
		{
			mLogger.Warn(message, argument);
		}
		public void Warn(IFormatProvider formatProvider, String message, Double argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn(String message, Double argument)
		{
			mLogger.Warn(message, argument);
		}
		public void Warn(IFormatProvider formatProvider, String message, Decimal argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn(String message, Decimal argument)
		{
			mLogger.Warn(message, argument);
		}
		public void Warn(IFormatProvider formatProvider, String message, Object argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn(String message, Object argument)
		{
			mLogger.Warn(message, argument);
		}
		public void Warn(IFormatProvider formatProvider, String message, SByte argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn(String message, SByte argument)
		{
			mLogger.Warn(message, argument);
		}
		public void Warn(IFormatProvider formatProvider, String message, UInt32 argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn(String message, UInt32 argument)
		{
			mLogger.Warn(message, argument);
		}
		public void Warn(IFormatProvider formatProvider, String message, UInt64 argument)
		{
			mLogger.Warn(formatProvider, message, argument);
		}
		public void Warn(String message, UInt64 argument)
		{
			mLogger.Warn(message, argument);
		}
		[Obsolete("Use Warn(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		public void WarnException(String message, Exception exception)
		{
			mLogger.WarnException(message, exception);
		}
	}
}
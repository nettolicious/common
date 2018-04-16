using System;
using System.Collections.Generic;
using System.Text;

namespace Nettolicious.Common.Logging
{
	public interface ILogger
	{

		//
		// Summary:
		//     Gets a value indicating whether logging is enabled for the Fatal level.
		//
		// Returns:
		//     A value of true if logging is enabled for the Fatal level, otherwise it returns
		//     false.
		bool IsFatalEnabled { get; }
		//
		// Summary:
		//     Gets a value indicating whether logging is enabled for the Warn level.
		//
		// Returns:
		//     A value of true if logging is enabled for the Warn level, otherwise it returns
		//     false.
		bool IsWarnEnabled { get; }
		//
		// Summary:
		//     Gets a value indicating whether logging is enabled for the Info level.
		//
		// Returns:
		//     A value of true if logging is enabled for the Info level, otherwise it returns
		//     false.
		bool IsInfoEnabled { get; }
		//
		// Summary:
		//     Gets a value indicating whether logging is enabled for the Debug level.
		//
		// Returns:
		//     A value of true if logging is enabled for the Debug level, otherwise it returns
		//     false.
		bool IsDebugEnabled { get; }
		//
		// Summary:
		//     Gets a value indicating whether logging is enabled for the Trace level.
		//
		// Returns:
		//     A value of true if logging is enabled for the Trace level, otherwise it returns
		//     false.
		bool IsTraceEnabled { get; }
		//
		// Summary:
		//     Gets a value indicating whether logging is enabled for the Error level.
		//
		// Returns:
		//     A value of true if logging is enabled for the Error level, otherwise it returns
		//     false.
		bool IsErrorEnabled { get; }

		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		void Debug(string message, int argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(IFormatProvider formatProvider, string message, int argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(IFormatProvider formatProvider, string message, string argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(string message, byte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(IFormatProvider formatProvider, string message, byte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(IFormatProvider formatProvider, string message, char argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(IFormatProvider formatProvider, string message, long argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(string message, bool argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(IFormatProvider formatProvider, string message, bool argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   arg1:
		//     First argument to format.
		//
		//   arg2:
		//     Second argument to format.
		//
		//   arg3:
		//     Third argument to format.
		
		
		void Debug(string message, object arg1, object arg2, object arg3);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   arg1:
		//     First argument to format.
		//
		//   arg2:
		//     Second argument to format.
		
		
		void Debug(string message, object arg1, object arg2);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(string message, char argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(string message, long argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(string message, float argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   value:
		//     A object to be written.
		
		void Debug(IFormatProvider formatProvider, object value);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(IFormatProvider formatProvider, string message, double argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(string message, double argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(IFormatProvider formatProvider, string message, decimal argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(string message, decimal argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(IFormatProvider formatProvider, string message, object argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(string message, object argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(IFormatProvider formatProvider, string message, sbyte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(string message, sbyte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(IFormatProvider formatProvider, string message, uint argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(string message, uint argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(IFormatProvider formatProvider, string message, ulong argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(string message, ulong argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(IFormatProvider formatProvider, string message, float argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level.
		//
		// Parameters:
		//   value:
		//     A object to be written.
		
		void Debug(object value);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Debug(string message, string argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		//   argument3:
		//     The third argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		//
		//   TArgument3:
		//     The type of the third argument.
		
		void Debug<TArgument1, TArgument2, TArgument3>( string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified arguments
		//     formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		//   argument3:
		//     The third argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		//
		//   TArgument3:
		//     The type of the third argument.
		
		void Debug<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider,  string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		
		void Debug<TArgument1, TArgument2>( string message, TArgument1 argument1, TArgument2 argument2);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified arguments
		//     formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		
		void Debug<TArgument1, TArgument2>(IFormatProvider formatProvider,  string message, TArgument1 argument1, TArgument2 argument2);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		//
		// Type parameters:
		//   TArgument:
		//     The type of the argument.
		
		void Debug<TArgument>( string message, TArgument argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified parameter
		//     and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		//
		// Type parameters:
		//   TArgument:
		//     The type of the argument.
		
		void Debug<TArgument>(IFormatProvider formatProvider,  string message, TArgument argument);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Debug level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		// Remarks:
		//     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
		//     a future release.
		[Obsolete("Use Debug(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void Debug( string message, Exception exception);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   args:
		//     Arguments to format.
		
		void Debug( string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level.
		//
		// Parameters:
		//   message:
		//     Log message.
		void Debug( string message);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level using the specified parameters
		//     and formatting them with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing format items.
		//
		//   args:
		//     Arguments to format.
		
		void Debug(IFormatProvider formatProvider,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Debug level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		//   args:
		//     Arguments to format.
		
		void Debug(Exception exception, IFormatProvider formatProvider,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Debug level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		//   args:
		//     Arguments to format.
		
		void Debug(Exception exception,  string message, params object[] args);
		
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   value:
		//     The value to be written.
		//
		// Type parameters:
		//   T:
		//     Type of the value.
		void Debug<T>(IFormatProvider formatProvider, T value);
		//
		// Summary:
		//     Writes the diagnostic message at the Debug level.
		//
		// Parameters:
		//   value:
		//     The value to be written.
		//
		// Type parameters:
		//   T:
		//     Type of the value.
		void Debug<T>(T value);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Debug level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		void Debug(Exception exception,  string message);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Debug level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		// Remarks:
		//     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
		//     a future release.
		[Obsolete("Use Debug(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void DebugException( string message, Exception exception);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		//   argument3:
		//     The third argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		//
		//   TArgument3:
		//     The type of the third argument.
		
		void Error<TArgument1, TArgument2, TArgument3>( string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   args:
		//     Arguments to format.
		
		void Error( string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Error level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		// Remarks:
		//     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
		//     a future release.
		[Obsolete("Use Error(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void Error( string message, Exception exception);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified parameter
		//     and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		//
		// Type parameters:
		//   TArgument:
		//     The type of the argument.
		
		void Error<TArgument>(IFormatProvider formatProvider,  string message, TArgument argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		//
		// Type parameters:
		//   TArgument:
		//     The type of the argument.
		
		void Error<TArgument>( string message, TArgument argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified arguments
		//     formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		
		void Error<TArgument1, TArgument2>(IFormatProvider formatProvider,  string message, TArgument1 argument1, TArgument2 argument2);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		
		void Error<TArgument1, TArgument2>( string message, TArgument1 argument1, TArgument2 argument2);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(string message, uint argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(IFormatProvider formatProvider, string message, uint argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(string message, sbyte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(IFormatProvider formatProvider, string message, sbyte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(string message, object argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(IFormatProvider formatProvider, string message, object argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(string message, decimal argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(IFormatProvider formatProvider, string message, decimal argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(string message, double argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(IFormatProvider formatProvider, string message, double argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		void Error(string message, float argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level.
		//
		// Parameters:
		//   message:
		//     Log message.
		void Error( string message);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(IFormatProvider formatProvider, string message, float argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified arguments
		//     formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		//   argument3:
		//     The third argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		//
		//   TArgument3:
		//     The type of the third argument.
		
		void Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider,  string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified parameters
		//     and formatting them with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing format items.
		//
		//   args:
		//     Arguments to format.
		
		void Error(IFormatProvider formatProvider,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level.
		//
		// Parameters:
		//   value:
		//     A object to be written.
		
		void Error(object value);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Error level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		//   args:
		//     Arguments to format.
		
		void Error(Exception exception,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   arg1:
		//     First argument to format.
		//
		//   arg2:
		//     Second argument to format.
		
		
		void Error(string message, object arg1, object arg2);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   arg1:
		//     First argument to format.
		//
		//   arg2:
		//     Second argument to format.
		//
		//   arg3:
		//     Third argument to format.
		
		
		void Error(string message, object arg1, object arg2, object arg3);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(IFormatProvider formatProvider, string message, bool argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		void Error(string message, bool argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(IFormatProvider formatProvider, string message, char argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(string message, char argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(IFormatProvider formatProvider, string message, byte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		void Error(string message, byte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(IFormatProvider formatProvider, string message, string argument);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Error level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		//   args:
		//     Arguments to format.
		
		void Error(Exception exception, IFormatProvider formatProvider,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(string message, string argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(string message, int argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(IFormatProvider formatProvider, string message, long argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(string message, long argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(IFormatProvider formatProvider, string message, ulong argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level.
		//
		// Parameters:
		//   value:
		//     The value to be written.
		//
		// Type parameters:
		//   T:
		//     Type of the value.
		void Error<T>(T value);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   value:
		//     The value to be written.
		//
		// Type parameters:
		//   T:
		//     Type of the value.
		void Error<T>(IFormatProvider formatProvider, T value);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level.
		//
		// Parameters:
		//   messageFunc:
		//     A function returning message to be written. Function is not evaluated if logging
		//     is not enabled.

		void Error(IFormatProvider formatProvider, object value);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Error level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		void Error(Exception exception,  string message);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(IFormatProvider formatProvider, string message, int argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Error level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Error(string message, ulong argument);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Error level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		// Remarks:
		//     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
		//     a future release.
		[Obsolete("Use Error(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void ErrorException( string message, Exception exception);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(string message, char argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   arg1:
		//     First argument to format.
		//
		//   arg2:
		//     Second argument to format.
		
		
		void Fatal(string message, object arg1, object arg2);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   arg1:
		//     First argument to format.
		//
		//   arg2:
		//     Second argument to format.
		//
		//   arg3:
		//     Third argument to format.
		
		
		void Fatal(string message, object arg1, object arg2, object arg3);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(IFormatProvider formatProvider, string message, bool argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(string message, bool argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(IFormatProvider formatProvider, string message, char argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level.
		//
		// Parameters:
		//   value:
		//     A object to be written.
		
		void Fatal(object value);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(IFormatProvider formatProvider, string message, byte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   value:
		//     A object to be written.
		
		void Fatal(IFormatProvider formatProvider, object value);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(IFormatProvider formatProvider, string message, string argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level.
		//
		// Parameters:
		//   value:
		//     The value to be written.
		//
		// Type parameters:
		//   T:
		//     Type of the value.
		void Fatal<T>(T value);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(IFormatProvider formatProvider, string message, float argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(string message, float argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(IFormatProvider formatProvider, string message, double argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(string message, double argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(IFormatProvider formatProvider, string message, decimal argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		void Fatal(string message, decimal argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(string message, object argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(IFormatProvider formatProvider, string message, sbyte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(string message, sbyte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(IFormatProvider formatProvider, string message, uint argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(string message, uint argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(IFormatProvider formatProvider, string message, ulong argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(string message, ulong argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(string message, byte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   value:
		//     The value to be written.
		//
		// Type parameters:
		//   T:
		//     Type of the value.
		void Fatal<T>(IFormatProvider formatProvider, T value);

		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(IFormatProvider formatProvider, string message, object argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		//   argument3:
		//     The third argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		//
		//   TArgument3:
		//     The type of the third argument.
		
		void Fatal<TArgument1, TArgument2, TArgument3>( string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(string message, long argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(IFormatProvider formatProvider, string message, int argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified arguments
		//     formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		//   argument3:
		//     The third argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		//
		//   TArgument3:
		//     The type of the third argument.
		
		void Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider,  string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		
		void Fatal<TArgument1, TArgument2>( string message, TArgument1 argument1, TArgument2 argument2);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Fatal level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		void Fatal(Exception exception,  string message);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified arguments
		//     formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		
		void Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider,  string message, TArgument1 argument1, TArgument2 argument2);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		//
		// Type parameters:
		//   TArgument:
		//     The type of the argument.
		
		void Fatal<TArgument>( string message, TArgument argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified parameter
		//     and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		//
		// Type parameters:
		//   TArgument:
		//     The type of the argument.
		
		void Fatal<TArgument>(IFormatProvider formatProvider,  string message, TArgument argument);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Fatal level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		// Remarks:
		//     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
		//     a future release.
		[Obsolete("Use Fatal(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void Fatal( string message, Exception exception);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   args:
		//     Arguments to format.
		
		void Fatal( string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level.
		//
		// Parameters:
		//   message:
		//     Log message.
		void Fatal( string message);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(string message, string argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified parameters
		//     and formatting them with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing format items.
		//
		//   args:
		//     Arguments to format.
		
		void Fatal(IFormatProvider formatProvider,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Fatal level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		//   args:
		//     Arguments to format.
		
		void Fatal(Exception exception, IFormatProvider formatProvider,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Fatal level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		//   args:
		//     Arguments to format.
		
		void Fatal(Exception exception,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(IFormatProvider formatProvider, string message, long argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Fatal level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Fatal(string message, int argument);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Fatal level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		// Remarks:
		//     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
		//     a future release.
		[Obsolete("Use Fatal(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void FatalException( string message, Exception exception);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(string message, int argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(IFormatProvider formatProvider, string message, int argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(IFormatProvider formatProvider, string message, long argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(string message, long argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(IFormatProvider formatProvider, string message, float argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(string message, string argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(string message, float argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(IFormatProvider formatProvider, string message, double argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(string message, double argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(IFormatProvider formatProvider, string message, decimal argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(string message, ulong argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(IFormatProvider formatProvider, string message, object argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(string message, object argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(IFormatProvider formatProvider, string message, sbyte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(string message, sbyte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(IFormatProvider formatProvider, string message, uint argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(string message, uint argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(IFormatProvider formatProvider, string message, ulong argument);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Info level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		//   args:
		//     Arguments to format.
		
		void Info(Exception exception,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(IFormatProvider formatProvider, string message, string argument);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Info level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		void Info(Exception exception,  string message);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(string message, decimal argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(string message, byte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		
		void Info<TArgument1, TArgument2>( string message, TArgument1 argument1, TArgument2 argument2);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(string message, char argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level.
		//
		// Parameters:
		//   value:
		//     The value to be written.
		//
		// Type parameters:
		//   T:
		//     Type of the value.
		void Info<T>(T value);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		//   argument3:
		//     The third argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		//
		//   TArgument3:
		//     The type of the third argument.
		
		void Info<TArgument1, TArgument2, TArgument3>( string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified arguments
		//     formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		//   argument3:
		//     The third argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		//
		//   TArgument3:
		//     The type of the third argument.
		
		void Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider,  string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified arguments
		//     formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		
		void Info<TArgument1, TArgument2>(IFormatProvider formatProvider,  string message, TArgument1 argument1, TArgument2 argument2);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		//
		// Type parameters:
		//   TArgument:
		//     The type of the argument.
		
		void Info<TArgument>( string message, TArgument argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified parameter
		//     and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		//
		// Type parameters:
		//   TArgument:
		//     The type of the argument.
		
		void Info<TArgument>(IFormatProvider formatProvider,  string message, TArgument argument);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Info level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		// Remarks:
		//     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
		//     a future release.
		[Obsolete("Use Info(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void Info( string message, Exception exception);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(IFormatProvider formatProvider, string message, byte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level.
		//
		// Parameters:
		//   message:
		//     Log message.
		void Info( string message);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   args:
		//     Arguments to format.
		
		void Info( string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Info level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		//   args:
		//     Arguments to format.
		
		void Info(Exception exception, IFormatProvider formatProvider,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   value:
		//     The value to be written.
		//
		// Type parameters:
		//   T:
		//     Type of the value.
		void Info<T>(IFormatProvider formatProvider, T value);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level.
		//
		// Parameters:
		//   value:
		//     A object to be written.
		
		void Info(object value);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   value:
		//     A object to be written.
		
		void Info(IFormatProvider formatProvider, object value);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   arg1:
		//     First argument to format.
		//
		//   arg2:
		//     Second argument to format.
		
		
		void Info(string message, object arg1, object arg2);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   arg1:
		//     First argument to format.
		//
		//   arg2:
		//     Second argument to format.
		//
		//   arg3:
		//     Third argument to format.
		
		
		void Info(string message, object arg1, object arg2, object arg3);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(IFormatProvider formatProvider, string message, bool argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(string message, bool argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Info(IFormatProvider formatProvider, string message, char argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Info level using the specified parameters
		//     and formatting them with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing format items.
		//
		//   args:
		//     Arguments to format.
		
		void Info(IFormatProvider formatProvider,  string message, params object[] args);

		//
		// Summary:
		//     Writes the diagnostic message and exception at the Info level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		// Remarks:
		//     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
		//     a future release.
		[Obsolete("Use Info(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void InfoException( string message, Exception exception);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   value:
		//     The value to be written.
		//
		// Type parameters:
		//   T:
		//     Type of the value.
		void Trace<T>(IFormatProvider formatProvider, T value);

		//
		// Summary:
		//     Writes the diagnostic message and exception at the Trace level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		void Trace(Exception exception,  string message);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Trace level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		//   args:
		//     Arguments to format.
		
		void Trace(Exception exception,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(string message, sbyte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(IFormatProvider formatProvider, string message, double argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(string message, double argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(IFormatProvider formatProvider, string message, decimal argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(string message, decimal argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(IFormatProvider formatProvider, string message, object argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(string message, object argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(string message, float argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(IFormatProvider formatProvider, string message, sbyte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(string message, uint argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(IFormatProvider formatProvider, string message, ulong argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(string message, ulong argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		//   argument3:
		//     The third argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		//
		//   TArgument3:
		//     The type of the third argument.
		
		void Trace<TArgument1, TArgument2, TArgument3>( string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified arguments
		//     formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		//   argument3:
		//     The third argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		//
		//   TArgument3:
		//     The type of the third argument.
		
		void Trace<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider,  string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		
		void Trace<TArgument1, TArgument2>( string message, TArgument1 argument1, TArgument2 argument2);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(IFormatProvider formatProvider, string message, uint argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified arguments
		//     formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		
		void Trace<TArgument1, TArgument2>(IFormatProvider formatProvider,  string message, TArgument1 argument1, TArgument2 argument2);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(IFormatProvider formatProvider, string message, float argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(IFormatProvider formatProvider, string message, long argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level.
		//
		// Parameters:
		//   value:
		//     A object to be written.
		
		void Trace(object value);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   value:
		//     A object to be written.
		
		void Trace(IFormatProvider formatProvider, object value);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   arg1:
		//     First argument to format.
		//
		//   arg2:
		//     Second argument to format.
		
		
		void Trace(string message, object arg1, object arg2);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   arg1:
		//     First argument to format.
		//
		//   arg2:
		//     Second argument to format.
		//
		//   arg3:
		//     Third argument to format.
		
		
		void Trace(string message, object arg1, object arg2, object arg3);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(IFormatProvider formatProvider, string message, bool argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(string message, bool argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(string message, long argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(IFormatProvider formatProvider, string message, char argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(IFormatProvider formatProvider, string message, byte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(string message, byte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(IFormatProvider formatProvider, string message, string argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(string message, string argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(IFormatProvider formatProvider, string message, int argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(string message, int argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Trace(string message, char argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		//
		// Type parameters:
		//   TArgument:
		//     The type of the argument.
		
		void Trace<TArgument>( string message, TArgument argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level.
		//
		// Parameters:
		//   value:
		//     The value to be written.
		//
		// Type parameters:
		//   T:
		//     Type of the value.
		void Trace<T>(T value);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Trace level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		// Remarks:
		//     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
		//     a future release.
		[Obsolete("Use Trace(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void Trace( string message, Exception exception);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   args:
		//     Arguments to format.
		
		void Trace( string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level.
		//
		// Parameters:
		//   message:
		//     Log message.
		void Trace( string message);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified parameters
		//     and formatting them with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing format items.
		//
		//   args:
		//     Arguments to format.
		
		void Trace(IFormatProvider formatProvider,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Trace level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		//   args:
		//     Arguments to format.
		
		void Trace(Exception exception, IFormatProvider formatProvider,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message at the Trace level using the specified parameter
		//     and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		//
		// Type parameters:
		//   TArgument:
		//     The type of the argument.
		
		void Trace<TArgument>(IFormatProvider formatProvider,  string message, TArgument argument);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Trace level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		// Remarks:
		//     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
		//     a future release.
		[Obsolete("Use Trace(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void TraceException( string message, Exception exception);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(IFormatProvider formatProvider, string message, string argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(string message, byte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(IFormatProvider formatProvider, string message, byte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(string message, char argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		//   argument3:
		//     The third argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		//
		//   TArgument3:
		//     The type of the third argument.
		
		void Warn<TArgument1, TArgument2, TArgument3>( string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified arguments
		//     formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		//   argument3:
		//     The third argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		//
		//   TArgument3:
		//     The type of the third argument.
		
		void Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider,  string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		
		void Warn<TArgument1, TArgument2>( string message, TArgument1 argument1, TArgument2 argument2);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified arguments
		//     formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument1:
		//     The first argument to format.
		//
		//   argument2:
		//     The second argument to format.
		//
		// Type parameters:
		//   TArgument1:
		//     The type of the first argument.
		//
		//   TArgument2:
		//     The type of the second argument.
		
		void Warn<TArgument1, TArgument2>(IFormatProvider formatProvider,  string message, TArgument1 argument1, TArgument2 argument2);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		//
		// Type parameters:
		//   TArgument:
		//     The type of the argument.
		
		void Warn<TArgument>( string message, TArgument argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level.
		//
		// Parameters:
		//   message:
		//     Log message.
		void Warn( string message);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Warn level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		// Remarks:
		//     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
		//     a future release.
		[Obsolete("Use Warn(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void Warn( string message, Exception exception);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   args:
		//     Arguments to format.
		
		void Warn( string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified parameters
		//     and formatting them with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing format items.
		//
		//   args:
		//     Arguments to format.
		
		void Warn(IFormatProvider formatProvider,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Warn level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		//   args:
		//     Arguments to format.
		
		void Warn(Exception exception, IFormatProvider formatProvider,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Warn level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		//   args:
		//     Arguments to format.
		
		void Warn(Exception exception,  string message, params object[] args);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Warn level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		void Warn(Exception exception,  string message);

		//
		// Summary:
		//     Writes the diagnostic message at the Warn level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   value:
		//     The value to be written.
		//
		// Type parameters:
		//   T:
		//     Type of the value.
		void Warn<T>(IFormatProvider formatProvider, T value);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level.
		//
		// Parameters:
		//   value:
		//     The value to be written.
		//
		// Type parameters:
		//   T:
		//     Type of the value.
		void Warn<T>(T value);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified parameter
		//     and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		//
		// Type parameters:
		//   TArgument:
		//     The type of the argument.
		
		void Warn<TArgument>(IFormatProvider formatProvider, string message, TArgument argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(string message, string argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(IFormatProvider formatProvider, string message, long argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(string message, int argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level.
		//
		// Parameters:
		//   value:
		//     A object to be written.
		
		void Warn(object value);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   value:
		//     A object to be written.
		
		void Warn(IFormatProvider formatProvider, object value);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   arg1:
		//     First argument to format.
		//
		//   arg2:
		//     Second argument to format.
		
		
		void Warn(string message, object arg1, object arg2);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(string message, bool argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified parameters.
		//
		// Parameters:
		//   message:
		//     A string containing format items.
		//
		//   arg1:
		//     First argument to format.
		//
		//   arg2:
		//     Second argument to format.
		//
		//   arg3:
		//     Third argument to format.
		
		
		void Warn(string message, object arg1, object arg2, object arg3);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(IFormatProvider formatProvider, string message, bool argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(string message, ulong argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(IFormatProvider formatProvider, string message, ulong argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(string message, uint argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(IFormatProvider formatProvider, string message, int argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(IFormatProvider formatProvider, string message, uint argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(IFormatProvider formatProvider, string message, sbyte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(string message, object argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(IFormatProvider formatProvider, string message, object argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(string message, decimal argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(IFormatProvider formatProvider, string message, decimal argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(string message, double argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(IFormatProvider formatProvider, string message, double argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(string message, float argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(IFormatProvider formatProvider, string message, float argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(string message, long argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter.
		//
		// Parameters:
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(string message, sbyte argument);
		//
		// Summary:
		//     Writes the diagnostic message at the Warn level using the specified value as
		//     a parameter and formatting it with the supplied format provider.
		//
		// Parameters:
		//   formatProvider:
		//     An IFormatProvider that supplies culture-specific formatting information.
		//
		//   message:
		//     A string containing one format item.
		//
		//   argument:
		//     The argument to format.
		
		
		void Warn(IFormatProvider formatProvider, string message, char argument);
		//
		// Summary:
		//     Writes the diagnostic message and exception at the Warn level.
		//
		// Parameters:
		//   message:
		//     A string to be written.
		//
		//   exception:
		//     An exception to be logged.
		//
		// Remarks:
		//     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
		//     a future release.
		[Obsolete("Use Warn(Exception exception, string message, params object[] args) method instead. Marked obsolete before v4.3.11")]
		void WarnException( string message, Exception exception);
	}
}

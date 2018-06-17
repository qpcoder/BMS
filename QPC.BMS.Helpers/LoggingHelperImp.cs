/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QPC.BMS.Helpers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;
    using log4net;
    using log4net.Core;

    public class LoggingHelperImp : ILoggingHelper
    {
        /// <summary>
        /// Declare instance for log4net
        /// </summary>
        private readonly ILog logger = LogManager.GetLogger("RollingLogFileAppender");

        private StringBuilder stringBuilder;

        public bool IsDebugEnabled => logger.IsDebugEnabled;

        public bool IsInfoEnabled => logger.IsInfoEnabled;

        public bool IsWarnEnabled => logger.IsWarnEnabled;

        public bool IsErrorEnabled => logger.IsErrorEnabled;

        public bool IsFatalEnabled => logger.IsFatalEnabled;

        public ILogger Logger => logger.Logger;

        public void Debug(object message)
        {
            if (IsDebugEnabled)
                logger.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            if (IsDebugEnabled)
            {
                stringBuilder = new StringBuilder(message.ToString());
                stringBuilder.Append(exception.Message);
                logger.Debug(stringBuilder);
            }
        }

        public void DebugFormat(string format, params object[] args)
        {
            if (IsDebugEnabled)
                logger.DebugFormat(format, args);
        }

        public void DebugFormat(string format, object arg0)
        {
            if (IsDebugEnabled)
                logger.DebugFormat(format, arg0);
        }

        public void DebugFormat(string format, object arg0, object arg1)
        {
            if (IsDebugEnabled)
                logger.DebugFormat(format, arg0, arg1);
        }

        public void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            if (IsDebugEnabled)
                logger.DebugFormat(format, arg0, arg1, arg2);
        }

        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (IsDebugEnabled)
                logger.DebugFormat(provider, format, args);
        }

        /// <summary>
        /// Release method
        /// </summary>
        /// <param name="callerFilePath"></param>
        /// <param name="callerLineNumber"></param>
        /// <param name="callerMember"></param>
        public void ReleaseMethod([CallerFilePath] string callerFilePath = "",
            [CallerLineNumber] long callerLineNumber = 0,
            [CallerMemberName] string callerMember = "")
        {
            if (IsDebugEnabled)
            {
                stringBuilder = new StringBuilder("After invoke:");
                stringBuilder.Append(" End call to function: " + callerMember);
                stringBuilder.Append(" at line: " + callerLineNumber);
                stringBuilder.Append(" in file: " + callerFilePath);
                logger.Debug(stringBuilder);
            }
        }

        /// <summary>
        /// Enter method
        /// </summary>
        /// <param name="callerFilePath"></param>
        /// <param name="callerLineNumber"></param>
        /// <param name="callerMember"></param>
        public void EnterMethod([CallerFilePath] string callerFilePath = "",
            [CallerLineNumber] long callerLineNumber = 0,
            [CallerMemberName] string callerMember = "")
        {
            if (logger.IsDebugEnabled)
            {
                stringBuilder = new StringBuilder("Before invoke:");
                stringBuilder.Append(" Begin call to function: " + callerMember);
                stringBuilder.Append(" at line: " + callerLineNumber);
                stringBuilder.Append(" in file: " + callerFilePath);
                logger.Debug(stringBuilder);
            }
        }

        public void Error(object message)
        {
            if (IsErrorEnabled)
                logger.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            if (IsErrorEnabled)
            {
                stringBuilder = new StringBuilder(message.ToString());
                stringBuilder.Append(exception.Message.ToString());
                logger.Error(stringBuilder);
            }
        }

        public void ErrorFormat(string format, params object[] args)
        {
            if (IsErrorEnabled)
                logger.ErrorFormat(format, args);
        }

        public void ErrorFormat(string format, object arg0)
        {
            if (IsErrorEnabled)
                logger.ErrorFormat(format, arg0);
        }

        public void ErrorFormat(string format, object arg0, object arg1)
        {
            if (IsErrorEnabled)
                logger.ErrorFormat(format, arg0, arg1);
        }

        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            if (IsErrorEnabled)
                logger.ErrorFormat(format, arg0, arg1, arg2);
        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (IsErrorEnabled)
                logger.ErrorFormat(provider, format, args);
        }

        public void Fatal(object message)
        {
            if (IsFatalEnabled)
                logger.Fatal(message);
        }

        public void Fatal(object message, Exception exception)
        {
            if (IsFatalEnabled)
            {
                stringBuilder = new StringBuilder(message.ToString());
                stringBuilder.Append(exception.Message);
                logger.Fatal(stringBuilder);
            }
        }

        public void FatalFormat(string format, params object[] args)
        {
            if (IsFatalEnabled)
                logger.FatalFormat(format, args);
        }

        public void FatalFormat(string format, object arg0)
        {
            if (IsFatalEnabled)
                logger.FatalFormat(format, arg0);
        }

        public void FatalFormat(string format, object arg0, object arg1)
        {
            if (IsFatalEnabled)
                logger.FatalFormat(format, arg0, arg1);
        }

        public void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            if (IsFatalEnabled)
                logger.FatalFormat(format, arg0, arg1, arg2);
        }

        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (IsFatalEnabled)
                logger.FatalFormat(provider, format, args);
        }

        public void Info(object message)
        {
            if (IsInfoEnabled)
                logger.Info(message);
        }

        public void Info(object message, Exception exception)
        {
            if (IsInfoEnabled)
            {
                stringBuilder = new StringBuilder(message.ToString());
                stringBuilder.Append(exception.Message);
                logger.Info(stringBuilder);
            }
        }

        public void InfoFormat(string format, params object[] args)
        {
            if (IsInfoEnabled)
                logger.InfoFormat(format, args);
        }

        public void InfoFormat(string format, object arg0)
        {
            if (IsInfoEnabled)
                logger.InfoFormat(format, arg0);
        }

        public void InfoFormat(string format, object arg0, object arg1)
        {
            if (IsInfoEnabled)
                logger.InfoFormat(format, arg0, arg1);
        }

        public void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            if (IsInfoEnabled)
                logger.InfoFormat(format, arg0, arg1, arg2);
        }

        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (IsInfoEnabled)
                logger.InfoFormat(provider, format, args);
        }

        public void Warn(object message)
        {
            if (IsWarnEnabled)
                logger.Warn(message);
        }

        public void Warn(object message, Exception exception)
        {
            if (IsWarnEnabled)
            {
                stringBuilder = new StringBuilder(message.ToString());
                stringBuilder.Append(exception.Message);
                logger.Warn(stringBuilder); ;
            }
        }

        public void WarnFormat(string format, params object[] args)
        {
            if (IsWarnEnabled)
                logger.WarnFormat(format, args);
        }

        public void WarnFormat(string format, object arg0)
        {
            if (IsWarnEnabled)
                logger.WarnFormat(format, arg0);
        }

        public void WarnFormat(string format, object arg0, object arg1)
        {
            if (IsWarnEnabled)
                logger.WarnFormat(format, arg0, arg1);
        }

        public void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            if (IsWarnEnabled)
                logger.WarnFormat(format, arg0, arg1, arg2);
        }

        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (IsWarnEnabled)
                logger.WarnFormat(provider, format, args);
        }
    }
}

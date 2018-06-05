/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QPCODERS.Utilities.Helpers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using log4net;
    using log4net.Core;

    /// <summary>
    /// Custom log4net
    /// </summary>
    public class LogCustomImp : ILoggerHelper
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
            logger.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            logger.Debug(message, exception);
        }

        public void DebugFormat(string format, params object[] args)
        {
            logger.DebugFormat(format, args);
        }

        public void DebugFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void DebugFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
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
            stringBuilder = new StringBuilder("After invoke:");
            stringBuilder.Append(" End call to function: " + callerMember);
            stringBuilder.Append(" at line: " + callerLineNumber);
            stringBuilder.Append(" in file: " + callerFilePath);
            logger.Debug(stringBuilder);
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
            stringBuilder = new StringBuilder("Before invoke:");
            stringBuilder.Append(" Begin call to function: " + callerMember);
            stringBuilder.Append(" at line: " + callerLineNumber);
            stringBuilder.Append(" in file: " + callerFilePath);
            logger.Debug(stringBuilder);
        }

        public void Error(object message)
        {
            throw new NotImplementedException();
        }

        public void Error(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Info(object message)
        {
            throw new NotImplementedException();
        }

        public void Info(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Warn(object message)
        {
            throw new NotImplementedException();
        }

        public void Warn(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, object arg0)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, object arg0, object arg1)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}

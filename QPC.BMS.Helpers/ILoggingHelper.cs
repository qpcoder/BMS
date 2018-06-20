/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Helpers
{
    using log4net;
    using System.Runtime.CompilerServices;

    public interface ILoggingHelper : ILog
    {
        /// <summary>
        /// Enter method
        /// </summary>
        /// <param name="callerFilePath"></param>
        /// <param name="callerLineNumber"></param>
        /// <param name="callerMember"></param>
        void EnterMethod([CallerFilePath] string callerFilePath = "", [CallerLineNumber] long callerLineNumber = 0, [CallerMemberName] string callerMember = "");

        /// <summary>
        /// Release method
        /// </summary>
        /// <param name="callerFilePath"></param>
        /// <param name="callerLineNumber"></param>
        /// <param name="callerMember"></param>
        void ReleaseMethod([CallerFilePath] string callerFilePath = "", [CallerLineNumber] long callerLineNumber = 0, [CallerMemberName] string callerMember = "");
        void Warn(object iNSERT_SUCCESS);
        void Info(object sEARCH_SUCCESSFUL);
    }
}

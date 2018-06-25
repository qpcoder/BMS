/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.WebApi.Helper
{
    using QPC.BMS.Helpers;
    using QPC.BMS.Helpers.Enum;
    using System.Web.Http;

    public class BaseApiController : ApiController
    {
        /// <summary>
        /// Handle instance for log4net
        /// </summary>
        internal readonly ILoggingHelper logger;

        /// <summary>
        /// Dependency Injection 
        /// </summary>
        public BaseApiController()
        {
            logger = Helpers.DependencyResolution.IoC.Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());
        }
    }
}
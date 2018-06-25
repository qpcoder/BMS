/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.WepApp.Helper
{
    using QPC.BMS.Helpers;
    using QPC.BMS.Helpers.Enum;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class BaseControllers : Controller
    {
        /// <summary>
        /// Handle instance for log4net
        /// </summary>
        internal readonly ILoggingHelper logger;

        /// <summary>
        /// Dependency Injection 
        /// </summary>
        public BaseControllers()
        {
            logger = Helpers.DependencyResolution.IoC.Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());
        }
    }
}
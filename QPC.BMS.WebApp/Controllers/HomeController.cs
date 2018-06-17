/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QPC.BMS.WebApp.Controllers
{
    using QPC.BMS.Helpers;
    using QPC.BMS.Helpers.Enum;
    using QPC.BMS.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        /// <summary>
        /// Handle instance for Log4Net
        /// </summary>
        ILoggingHelper logger = Helpers.DependencyResolution.IoC.Container()
            .GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());

        /// <summary>
        /// Handle instance for feature Account of BMS
        /// </summary>
        IAccountServices accountServices = QPC.BMS.Services.DependencyResolution.IoC.Container()
            .GetInstance<IAccountServices>(TargetImplement.V1.ToString());

        public ActionResult Index()
        {
            logger.EnterMethod();
            ViewBag.Title = "Home Page";

           if(accountServices.Login("admin", "admin"))
            {
                
            }

            return View();
        }
    }
}

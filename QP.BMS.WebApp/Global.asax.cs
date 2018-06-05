using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;

namespace QP.BMS.WebApp
{
    public class Global : HttpApplication
    {
        #region Variable System
        /// <summary>
        /// Name of company
        /// </summary>
        public static String CompanyName { get; set; }

        /// <summary>
        /// SEO character
        /// </summary>
        public static String SeoCharacter { get; set; }

        /// <summary>
        /// Logo of company
        /// </summary>
        public static String Favicon { get; set; }
        #endregion

        /// <summary>
        /// Get all information system
        /// </summary>
        /// <returns></returns>
        public static bool LoadInfoSystem()
        {
            return true;
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }

        void Application_End(object sender, EventArgs e)
        {

        }
    }
}
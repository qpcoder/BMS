﻿
namespace QPC.BMS.WebApp
{
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            /// create database if model is changed

            ///Connfiguration Log4Net
            log4net.Config.XmlConfigurator.Configure();
        }

        protected void Session_Start()
        {

        }

        protected void Session_End()
        {

        }

        protected void Application_Error()
        {

        }

        protected void Application_End()
        {

        }
    }
}

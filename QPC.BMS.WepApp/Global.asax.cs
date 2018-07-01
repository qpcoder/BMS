using QPC.BMS.Helpers;
using QPC.BMS.Helpers.Enum;
using QPC.BMS.Models;
using QPC.BMS.Services;
using QPC.BMS.WepApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace QPC.BMS.WepApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Khai bao bien system services
        /// </summary>
        private ISystemServices systemServices;

        /// <summary>
        /// Khai bao bien network helper
        /// </summary>
        private NetworkHelper networkHelper;

        /// <summary>
        /// Dependency Injection 
        /// </summary>
        public WebApiApplication()
        {
            systemServices = Services.DependencyResolution.IoC.Container().GetInstance<ISystemServices>(TargetImplement.V1.ToString());

            networkHelper = new NetworkHelper();
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ///Connfiguration Log4Net
            log4net.Config.XmlConfigurator.Configure();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Duoc thi thu khi ung dung phat sinh ra loi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Error(object sender, EventArgs e)
        {
            /// Lay ra cai loi
            Exception exception = Server.GetLastError();

#if DEBUG
            /// Khi dang debug thi viet log vao database
            systemServices.SetSystemExceptionLog(exception, Request.Url.AbsoluteUri, Session["accountID"].ToString());

            /// Update:
            /// Dung api thay cho goi ve services de luu lai cac exeption
            /// Dung ham: networkHelper.SendGetRequest() de lay ve goi respons
#endif

            /// Log the exeption
            Response.Clear();

            HttpException httpException = exception as HttpException;

            RouteData routeData = new RouteData();
            routeData.Values.Add("controller", "Error");

            if(httpException == null)
            {
                routeData.Values.Add("action", "Index");
            }else{
                /// It's an Http Exception, Let's handle it.
                switch(httpException.GetHttpCode()){
                    case 404: 
                    /// Page not found
                    routeData.Values.Add("action", "HttpError404");
                        break;
                    case 500:
                        /// Server error
                        routeData.Values.Add("action", "HttpError500");
                        break;
                }
            }

            // Pass exception details to the target error View.
            routeData.Values.Add("error", exception);

            // Clear the error on server.
            Server.ClearError();

            // Avoid IIS7 getting in the middle
            Response.TrySkipIisCustomErrors = true;

            // Call target Controller and pass the routeData.
            IController errorController = new ErrorController();
            errorController.Execute(new RequestContext(
                 new HttpContextWrapper(Context), routeData));
        }

        /// <summary>
        /// Phien giao dich cua nguoi dung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["accountID"] = String.Empty;
            if (String.IsNullOrEmpty(Session["accountID"].ToString()))
                Response.Redirect("~/Admin/Home/Login");
        }

        /// <summary>
        /// Dong phien giao dich
        /// Sau khoan thoi gian sessionState duoc cau hinh trong config thi thuc hien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Session_End(object sender, EventArgs e)
        {
            Session["accountID"] = String.Empty;
            Response.Redirect("~/Admin/Home/Login");
        }
    }
}

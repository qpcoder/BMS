/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using System;
using System.Web;
using System.Web.Mvc;

namespace AdvertisingOnline.Helpers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class FileDownloadHelpers : ActionFilterAttribute
    {
        public FileDownloadHelpers(string cookieName = "fileDownload", string cookiePath = "/")
        {
            CookieName = cookieName;
            CookiePath = cookiePath;
        }

        public string CookieName { get; set; }

        public string CookiePath { get; set; }

        private void CheckAndHandleFileResult(ActionExecutedContext filterContext)
        {
            var httpContext = filterContext.HttpContext;
            var response = httpContext.Response;

            if (filterContext.Result is FileResult)
                //jquery.fileDownload uses this cookie to determine that a file download has completed successfully
                response.AppendCookie(new HttpCookie(CookieName, "true") { Path = CookiePath });
            else
                //ensure that the cookie is removed in case someone did a file download without using jquery.fileDownload
                if (httpContext.Request.Cookies[CookieName] != null)
                {
                    response.AppendCookie(new HttpCookie(CookieName, "true") { Expires = DateTime.Now.AddYears(-1), Path = CookiePath });
                }
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            CheckAndHandleFileResult(filterContext);

            base.OnActionExecuted(filterContext);
        }
    }
}
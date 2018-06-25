/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.WepApp.Controllers
{
    using QPC.BMS.WepApp.Helper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    using System.Web.Mvc;
    public class HomeController : BaseControllers
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}

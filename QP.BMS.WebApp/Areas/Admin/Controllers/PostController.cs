﻿/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QP.BMS.WebApp.Areas.Admin.Controllers
{
    public class PostController : Controller
    {
        // GET: Admin/Post
        public ActionResult Index()
        {
            return View();
        }
    }
}
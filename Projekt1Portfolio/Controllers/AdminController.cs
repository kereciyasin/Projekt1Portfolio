﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt1Portfolio.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
			return PartialView();
		}
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
    }
}
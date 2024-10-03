﻿using Projekt1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt1Portfolio.Controllers
{
     
    public class DefaultController : Controller
    {
        MyPortfolio5DbEntities context = new MyPortfolio5DbEntities();  
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeader()
        {
            ViewBag.about = context.Tbl_About.Select(x => x.Title).FirstOrDefault();
            ViewBag.details = context.Tbl_About.Select(x => x.Detail).FirstOrDefault();
            ViewBag.image = context.Tbl_About.Select(x => x.ImageUrl).FirstOrDefault();    
            return PartialView();
        }
    }
}
using Projekt1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Projekt1Portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolio5DbEntities database = new MyPortfolio5DbEntities();

        public ActionResult Index()
        {
            var values = database.Tbl_Experience.ToList();
            return View(values);
        }
    }
}
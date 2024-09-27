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

        public ActionResult ExperienceList()
        {
            var values = database.Tbl_Experience.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateExperience(Tbl_Experience p)
        {
            database.Tbl_Experience.Add(p);
            database.SaveChanges();
            return RedirectToAction("ExperienceList");
        }   
    }
}
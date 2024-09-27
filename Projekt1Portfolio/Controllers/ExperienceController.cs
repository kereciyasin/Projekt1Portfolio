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
        public ActionResult CreateExperience(Tbl_Experience create)
        {
            database.Tbl_Experience.Add(create);
            database.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        public ActionResult DeleteExperience(int id)
        {
            var value = database.Tbl_Experience.Find(id);
            database.Tbl_Experience.Remove(value);
            database.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var value = database.Tbl_Experience.Find(id);
            return View("UpdateExperience", value);
        }
        [HttpPost]
        public ActionResult UpdateExperience(Tbl_Experience p)
        {
            var value = database.Tbl_Experience.Find(p.ExperienceId);
            value.CompanyName = p.CompanyName;
            value.WorkDate = p.WorkDate;
            value.Title = p.Title;
            value.Description = p.Description;
            database.SaveChanges();
            return RedirectToAction("ExperienceList");
        }   
    }
}
using Projekt1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt1Portfolio.Controllers
{
    public class EducationController : Controller
    {
        MyPortfolio5DbEntities db = new MyPortfolio5DbEntities();
        // GET: Education
        public ActionResult EducationList()
        {
            var values = db.Tbl_Education.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEducation(Tbl_Education p)
        {
            db.Tbl_Education.Add(p);
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var education = db.Tbl_Education.Find(id);
            return View("UpdateEducation", education);
        }
        [HttpPost]
        public ActionResult UpdateEducation(Tbl_Education p)
        {
            var education = db.Tbl_Education.Find(p.EducationId);
            education.Title = p.Title;
            education.EducationDate = p.EducationDate;
            education.SubTitle = p.SubTitle;
            education.Desciption = p.Desciption;
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }



        public ActionResult DeleteEducation(int id)
        {
            var education = db.Tbl_Education.Find(id);
            db.Tbl_Education.Remove(education);
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }

    }
}
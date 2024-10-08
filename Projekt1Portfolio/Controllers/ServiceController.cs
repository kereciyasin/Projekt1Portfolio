using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekt1Portfolio.Models; 

namespace Projekt1Portfolio.Controllers
{
    public class ServiceController : Controller
    {
        MyPortfolio5DbEntities db = new MyPortfolio5DbEntities();   
        public ActionResult ServiceIndex()
        {
            var service = db.Tbl_Services.ToList(); 
            return View(service);
        }

        public ActionResult ServiceDelete(int id)
        {
            var service = db.Tbl_Services.Find(id);
            db.Tbl_Services.Remove(service);
            db.SaveChanges();
            return RedirectToAction("ServiceIndex");
        }   

        [HttpGet]
        public ActionResult ServiceAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ServiceAdd(Tbl_Services service)
        {
            db.Tbl_Services.Add(service);
            db.SaveChanges();
            return RedirectToAction("ServiceIndex");
        }
        [HttpGet]
        public ActionResult ServiceEdit(int id)
        {
            var service = db.Tbl_Services.Find(id);
            return View(service);
        }
        [HttpPost]
        public ActionResult ServiceEdit(Tbl_Services service)
        {
            db.Entry(service).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ServiceIndex");
        }
    }
}
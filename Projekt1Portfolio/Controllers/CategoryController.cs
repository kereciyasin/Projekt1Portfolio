using Projekt1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt1Portfolio.Controllers
{
    public class CategoryController : Controller
    {
        MyPortfolio5DbEntities db = new MyPortfolio5DbEntities();
        // Method
        public ActionResult CategoryList()
        {
            var values = db.Tbl_Category.ToList();
            return View(values);
        }

        public ActionResult DeleteCategory(int id)
        {
            var category = db.Tbl_Category.Find(id);
            var messages = db.Tbl_Message.Where(x => x.CategoryId == id).ToList();
            foreach (var message in messages)
            {
                db.Tbl_Message.Remove(message);
                db.SaveChanges();
            }
            db.Tbl_Category.Remove(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }


        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Tbl_Category p)
        {
            db.Tbl_Category.Add(p);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var category = db.Tbl_Category.Find(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Tbl_Category p)
        {
            var category = db.Tbl_Category.Find(p.CategoryId);
            category.CategoryName = p.CategoryName;
            category.CategoryStatus = p.CategoryStatus; 
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }


    }
}
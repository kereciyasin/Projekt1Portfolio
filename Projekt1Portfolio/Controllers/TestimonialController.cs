using Projekt1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt1Portfolio.Controllers
{
    public class TestimonialController : Controller
    {
        MyPortfolio5DbEntities context = new MyPortfolio5DbEntities();
        public ActionResult TestimonialList()
        {
            var values = context.Tbl_Testimonial.ToList();
            return View(values);
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var values = context.Tbl_Testimonial.Find(id);
            context.Tbl_Testimonial.Remove(values);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(Tbl_Testimonial testimonial)
        {
            context.Tbl_Testimonial.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = context.Tbl_Testimonial.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(Tbl_Testimonial testimonial)
        {
            var values = context.Tbl_Testimonial.Find(testimonial.TestimonialId);
            values.Title = testimonial.Title;
            values.Name = testimonial.Name;
            values.Comment = testimonial.Comment;
            values.ImageUrl = testimonial.ImageUrl;
            values.Contry = testimonial.Contry; 
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }


    }
}
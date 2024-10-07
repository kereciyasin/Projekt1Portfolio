using Projekt1Portfolio.Models;
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

        [HttpGet]
        public ActionResult Index(Tbl_Message message)
        {
            message.SendDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            message.IsRead = false;
            context.Tbl_Message.Add(message);
            context.SaveChanges();
            return RedirectToAction("Index");   
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

            ViewBag.address = context.Tbl_Profile.Select(x => x.Address).FirstOrDefault();
            ViewBag.email = context.Tbl_Profile.Select(x => x.Email).FirstOrDefault();
            ViewBag.phone = context.Tbl_Profile.Select(x => x.PhoneNumber).FirstOrDefault();
            ViewBag.github = context.Tbl_Profile.Select(x => x.Github).FirstOrDefault();
            

            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            ViewBag.title = context.Tbl_Profile.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = context.Tbl_Profile.Select(x => x.Description).FirstOrDefault();
            ViewBag.email = context.Tbl_Profile.Select(x => x.Email).FirstOrDefault();
            ViewBag.address = context.Tbl_Profile.Select(x => x.Address).FirstOrDefault();  
            ViewBag.phone = context.Tbl_Profile.Select(x => x.PhoneNumber).FirstOrDefault();
            ViewBag.image = context.Tbl_Profile.Select(x => x.ImageUrl).FirstOrDefault();

            ViewBag.socialMediaUrl = context.SocialMedia.Select(x => x.SocialMediaUrl).FirstOrDefault();
            ViewBag.socialMediaIcon = context.SocialMedia.Select(x => x.Icon).FirstOrDefault();
            PartialSocialMedia();


            return PartialView();
        }
        public PartialViewResult PartialEducation()
        {
            var values = context.Tbl_Education.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();   
        }
        public PartialViewResult PartialSkill()
        {
            var values = context.Tbl_Skill.ToList();
            return PartialView(values); 
        }
        public PartialViewResult PartialSocialMedia()
        {
            var values = context.SocialMedia.Where(x => x.Status == true).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialExperience()
        {
            var values = context.Tbl_Experience.ToList();
            return PartialView(values);
        }   

        public PartialViewResult PartialService()
        {
            var values = context.Tbl_Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialPortfolio()
        {
            var values = context.Tbl_Work.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = context.Tbl_Testimonial.ToList();
            return PartialView(values);
        }

    }
}
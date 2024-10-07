using Projekt1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt1Portfolio.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolio5DbEntities db = new MyPortfolio5DbEntities();
        public ActionResult PartialContactSideBar()
        {
            return PartialView();
        }
        public ActionResult PartialContactAddress()
        {
            ViewBag.Desciption = db.Tbl_Profile.Select(x => x.Description).FirstOrDefault();
            ViewBag.Address = db.Tbl_Profile.Select(x => x.Address).FirstOrDefault();
            ViewBag.Phone = db.Tbl_Profile.Select(x => x.PhoneNumber).FirstOrDefault();
            ViewBag.Email = db.Tbl_Profile.Select(x => x.Email).FirstOrDefault();

            return PartialView();
        }

        public ActionResult PartialContactLocation()
        {
            ViewBag.Location = db.Tbl_Profile.Select(x => x.MapLocation).FirstOrDefault();
            return PartialView();
        }



    }
}
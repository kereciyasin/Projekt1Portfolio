using Projekt1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt1Portfolio.Controllers
{
    public class ProfileController : Controller
    {
        MyPortfolio5DbEntities db = new MyPortfolio5DbEntities();   
        // GET: Profile
        public ActionResult Index()

        {
            return View();
        }

        public ActionResult About()
        {
            var values = db.Tbl_Profile.ToList();   
            return View(values);
        }
    }
}
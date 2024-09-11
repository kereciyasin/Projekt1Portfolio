using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt1Portfolio.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult EducationList()
        {
            return View();
        }

        // burasi yeni bir giris alanidir.
		public ActionResult CreateEducation()
		{
			return View();
		}
	}
}
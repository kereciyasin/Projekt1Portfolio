using Projekt1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt1Portfolio.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolio5DbEntities context = new MyPortfolio5DbEntities();  
		public ActionResult SkillList()
        {
            var values = context.Tbl_Skill.ToList(); 
			return View();
        }
    }
}
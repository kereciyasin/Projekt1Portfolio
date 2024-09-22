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
			return View(values);
        }

        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
		public ActionResult CreateSkill(Tbl_Skill skill)
		{
            context.Tbl_Skill.Add(skill);
			context.SaveChanges();  
			return RedirectToAction("SkillList");  
		}
	}
}
using Projekt1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace Projekt1Portfolio.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolio5DbEntities context = new MyPortfolio5DbEntities();
        public ActionResult SkillList(int page = 1)
        {
            var values = context.Tbl_Skill.ToList().ToPagedList(page, 5);
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

        public ActionResult DeleteSkill(int id)
        {
            var value = context.Tbl_Skill.Find(id);
            context.Tbl_Skill.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public ActionResult GetSkillData()
        {
            var skillData = context.Tbl_Skill.Select(s => new { s.Title, s.Value }).ToList();
            return Json(skillData, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SkillGraph()
        {
            return View();
        }
    }
}
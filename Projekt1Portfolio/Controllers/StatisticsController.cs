using Projekt1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt1Portfolio.Controllers
{
    public class StatisticsController : Controller
    {
        MyPortfolio5DbEntities context = new MyPortfolio5DbEntities();  
        public ActionResult Index()
        {
            /* Mesaj sayisini */
            int messageCount = context.Tbl_Message.Count();
            /*  */
            int messageCountIsReadyByTrue = context.Tbl_Message.Where(x => x.IsRead == true).Count();   
            int messageCountIsReadyByFalse = context.Tbl_Message.Where(x => x.IsRead == false).Count();
            int skillCount = context.Tbl_Skill.Count();
            /* Skillerin Value si topla. */
            var totalSkillValue = context.Tbl_Skill.Sum(x => x.Value);
            /* Skillerin ortalamasini bul. */
            var averageSkillValue = context.Tbl_Skill.Average(x => x.Value);    
            var getEmailFromProfile = context.Tbl_Profile.Select(x => x.Email).FirstOrDefault();  
            var getLastCategoryId = context.Tbl_Category.Max(x => x.CategoryId);
            var getLastCategoryName = context.Tbl_Category.Where(x => x.CategoryId == getLastCategoryId).Select(x => x.CategoryName).FirstOrDefault();

            ViewBag.MessageCount = messageCount;
            ViewBag.MessageCountIsReadyByTrue = messageCountIsReadyByTrue;
            ViewBag.MessageCountIsReadyByFalse = messageCountIsReadyByFalse;
            ViewBag.SkillCount = skillCount;
            ViewBag.TotalSkillValue = totalSkillValue;
            ViewBag.AverageSkillValue = averageSkillValue;
            ViewBag.GetEmailFromProfil = getEmailFromProfile;
            ViewBag.GetLastCategoryId = getLastCategoryId;
            ViewBag.GetLastCategoryName = getLastCategoryName;

            return View();
        }
    }
}
﻿using Projekt1Portfolio.Models;
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
            int messageCount = context.Tbl_Message.Count();
            int messageCountIsReadyByTrue = context.Tbl_Message.Where(x => x.IsRead == true).Count();   
            int messageCountIsReadyByFalse = context.Tbl_Message.Where(x => x.IsRead == false).Count();
            int skillCount = context.Tbl_Skill.Count();
            var totalSkillValue = context.Tbl_Skill.Sum(x => x.Value);  
            var averageSkillValue = context.Tbl_Skill.Average(x => x.Value);    
            var getEmailFromProfile = context.Tbl_Profile.Select(x => x.Email).FirstOrDefault();    
            

            return View();
        }
    }
}
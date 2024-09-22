using Projekt1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt1Portfolio.Controllers
{
    public class MessageController : Controller
    {
		MyPortfolio5DbEntities database = new MyPortfolio5DbEntities();   
		public ActionResult Inbox()
        {
            var values = database.Tbl_Message.ToList();    
			return View(values);
        }
    }
}
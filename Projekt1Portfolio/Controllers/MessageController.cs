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
        public ActionResult MessageDetails(int id)
        {
            var value = database.Tbl_Message.Where(x => x.KontaktId == id).FirstOrDefault();
            return View(value);
        }

        public ActionResult MessageStatusChanceToTrue(int id)
        {
            var value = database.Tbl_Message.Where(x => x.KontaktId == id).FirstOrDefault();
			value.IsRead = true;
			database.SaveChanges();
			return RedirectToAction("Inbox");   
		}
		public ActionResult MessageStatusChanceToFalse(int id)
		{
			var value = database.Tbl_Message.Where(x => x.KontaktId == id).FirstOrDefault();
			value.IsRead = false;
			database.SaveChanges();
			return RedirectToAction("Inbox");

		}   
        DivideByZeroException   
	}
}
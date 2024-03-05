using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class AdminNotificationController : Controller
    {
        TasteContext context = new TasteContext();
        public ActionResult NotificationsList()
        {
            var values = context.Notifications.ToList();
            return View(values);
        }
        public ActionResult NotificationIsReadChangeToTrue(int id)
        {
            var values = context.Notifications.Find(id);
            values.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("NotificationsList");
        }
        public ActionResult NotificationIsReadChangeToFalse(int id)
        {
            var values = context.Notifications.Find(id);
            values.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("NotificationsList");
        }
    }
}
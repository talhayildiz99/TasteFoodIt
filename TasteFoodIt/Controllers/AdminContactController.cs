using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Entities;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class AdminContactController : Controller
    {
        TasteContext context = new TasteContext();
        public ActionResult ContactList()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult OpenMessage(int id)
        {
            var value = context.Contacts.Find(id);
            context.SaveChanges();
            return View(value);
        }

        [HttpPost]
        public ActionResult OpenMessage()
        {
            return RedirectToAction("ContactList");
        }

        public ActionResult DeleteMessage(int id)
        {
            var value = context.Contacts.Find(id);
            context.Contacts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
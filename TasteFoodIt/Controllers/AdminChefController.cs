using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;
using TasteFoodIt.Entities;

namespace TasteFoodIt.Controllers
{
    public class AdminChefController : Controller
    {
        TasteContext context = new TasteContext();
        public ActionResult ChefList()
        {
            var values = context.Chefs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateChef()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateChef(Chef Chef)
        {
            context.Chefs.Add(Chef);
            context.SaveChanges();
            return RedirectToAction("ChefList");

        }
        public ActionResult DeleteChef(int id)
        {
            var values = context.Chefs.Find(id);
            context.Chefs.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ChefList");
        }

        [HttpGet]
        public ActionResult UpdateChef(int id)
        {
            var value = context.Chefs.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateChef(Chef Chef)
        {
            var value = context.Chefs.Find(Chef.ChefId);
            value.NameSurname = Chef.NameSurname;
            value.Title = Chef.Title;
            value.Description = Chef.Description;
            value.ImageUrl = Chef.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("ChefList");

        }
    }
}
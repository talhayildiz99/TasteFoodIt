using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Entities;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class DefaultController : Controller
    {
        TasteContext context = new TasteContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbarInfo()
        {
            ViewBag.phone = context.Adresses.Select(x => x.Phone).FirstOrDefault();
            ViewBag.email = context.Adresses.Select(y => y.Email).FirstOrDefault();
            ViewBag.description = context.Adresses.Select(z => z.Description).FirstOrDefault();
            return PartialView();
        }
    }
}
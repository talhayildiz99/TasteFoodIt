using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class DetailController : Controller
    {
        TasteContext context = new TasteContext();
        // GET: Detail

        public ActionResult About()
        {
            ViewBag.pageName = "Hakkımızda";
            return View();
        }

        public ActionResult Chef()
        {
            ViewBag.pageName = "Şeflerimiz";
            var chef = context.Chefs.ToList();
            return View(chef);
        }

        public ActionResult Menu()
        {
            ViewBag.pageName = "Menü";
            var menu = context.Products.ToList();
            return View(menu);
        }

        public ActionResult Reservation()
        {
            ViewBag.pageName = "Rezervasyon";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.pageName = "İletişim";
            ViewBag.phone = context.Adresses.Select(x => x.Phone).FirstOrDefault();
            ViewBag.email = context.Adresses.Select(x => x.Email).FirstOrDefault();
            ViewBag.description = context.Adresses.Select(x => x.Description).FirstOrDefault();
            return View();
        }
       
    }
}
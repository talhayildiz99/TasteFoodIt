using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFoodIt.Entities;
using TasteFoodIt.Context;

namespace TasteFoodIt.Controllers
{
    public class AdminAddressController : Controller
    {
        // GET: AdminAddress
        TasteContext context = new TasteContext();

        public ActionResult AddressList()
        {
            ViewBag.name = "Adress";
            var values = context.Adresses.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAddress()
        {
            ViewBag.name = "Adress";
            return View();
        }
        [HttpPost]
        public ActionResult CreateAddress(Address Address)
        {

            context.Adresses.Add(Address);
            context.SaveChanges();
            return RedirectToAction("AddressList");

        }
        public ActionResult DeleteAddress(int id)
        {

            var values = context.Adresses.Find(id);
            context.Adresses.Remove(values);
            context.SaveChanges();
            return RedirectToAction("AddressList");
        }
        [HttpGet]
        public ActionResult UpdateAddress(int id)
        {
            ViewBag.name = "Adress";
            var value = context.Adresses.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAddress(Address address)
        {
            var value = context.Adresses.Find(address.AddressId);
            value.Description = address.Description;
            value.Email = address.Email;
            value.Phone = address.Phone;
            context.SaveChanges();
            return RedirectToAction("AddressList");

        }
    }
}
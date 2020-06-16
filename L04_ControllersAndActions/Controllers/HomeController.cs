using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace L04_ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string customer, int quantity, string deliveredBy, string receivedBy)
        {
            ViewBag.Customer = customer;
            ViewBag.Quantity = quantity;
            ViewBag.DeliveredBy = deliveredBy;
            ViewBag.ReceivedBy = receivedBy;

            return View();
        }

    }
}
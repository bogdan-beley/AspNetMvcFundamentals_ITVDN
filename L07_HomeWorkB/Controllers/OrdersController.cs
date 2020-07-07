using L07_HomeWorkB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L07_HomeWorkB.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Order order)
        {
            Debug.WriteLine(order.Name);
            Debug.WriteLine(order.Address);
            Debug.WriteLine(order.Date);
            Debug.WriteLine(order.Email);
            Debug.WriteLine(order.TermsAccepted);

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L05_HtmlHelperMethods.Controllers
{
    public class ExternalHelperMethodController : Controller
    {
        // GET: ExternalHelperMethod
        public ActionResult Index()
        {
            ViewBag.Fruits = new string[] { "Apples", "Bananas", "Mangos" };
            ViewBag.Days = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday",
                                         "Friday","Saturday", "Sunday"};
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registration()
        {
            var model = new Registration()
            {
                Id = 0,
                Name = "Enter your Name",
                Password = "Enter your password"
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Registration(Registration model)
        {
            Debug.WriteLine(model.Name);

            return View();
        }
    }
}
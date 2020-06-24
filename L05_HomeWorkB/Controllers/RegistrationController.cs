using L05_HomeWorkB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L05_HomeWorkB.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            RegistrationModel model = new RegistrationModel()
            {
                Id = 0,
                Login = "Create your login",
                Password = "Create your password",
                ConfirmPass = "Confirm your password",
                Email = "Enter your email"
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(RegistrationModel incomingData)
        {
            ViewBag.Id = incomingData.Id;
            ViewBag.Login = incomingData.Login;
            ViewBag.Password = incomingData.Password;
            ViewBag.ConfirmPass = incomingData.ConfirmPass;
            ViewBag.Email = incomingData.Email;

            return View();
        }
    }
}
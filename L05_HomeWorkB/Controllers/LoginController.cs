using L05_HomeWorkB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L05_HomeWorkB.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            LoginModel model = new LoginModel()
            {
                Login = "Enter your login",
                Password = "Enter your password"
            };
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(LoginModel incomingData)
        {
            ViewBag.Login = incomingData.Login;
            ViewBag.Password = incomingData.Password;

            return View();
        }
    }
}
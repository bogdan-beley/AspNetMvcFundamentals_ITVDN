using L04_HomeWorkB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace L04_HomeWorkB.Controllers
{
    public class AutorizationController : Controller
    {
        // GET: Autorization
        public ActionResult Login()
        {
            List<Login> logins = new List<Login>();

            logins.Add(new Login()
            {
                Username = TempData["username"] as string,
                Password = TempData["password"] as string
            });

            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            

            TempData["username"] = username;
            TempData["password"] = password;

            return View();
        }

        public ActionResult Registration()
        {
            List<Registration> registrations = new List<Registration>();

            registrations.Add(new Registration()
            {
                Username = TempData["username"] as string,
                Password = TempData["password"] as string,
                PassConfirm = TempData["passconfirm"] as string,
                Email = TempData["email"] as string
            });

            return View();
        }

        [HttpPost]
        public ActionResult Registration(string username, string password, string passconfirm, string email)
        {
            TempData["username"] = username;
            TempData["password"] = password;
            TempData["passconfirm"] = passconfirm;
            TempData["email"] = email;
           
            return View();
        }
    }
}
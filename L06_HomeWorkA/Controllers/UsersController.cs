using L06_HomeWorkA.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L06_HomeWorkA.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(User incommingData)
        {
            Debug.WriteLine(incommingData.Id);
            Debug.WriteLine(incommingData.Login);
            Debug.WriteLine(incommingData.FullName);
            Debug.WriteLine(incommingData.Password);
            Debug.WriteLine(incommingData.RegisterDate);

            return View("Index");
        }
    }
}
using L06_HomeWorkB1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L06_HomeWorkB1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PhoneNumber pn = new PhoneNumber();
            return View(pn);
        }

        [HttpPost]
        public ActionResult Index(PhoneNumber incomingData)
        {
            string result = incomingData.CountryCode + incomingData.CityCode + incomingData.Number;
            string number = string.Empty;
            foreach (var item in result)
            {
                if (char.IsDigit(item))
                    number += item;
            }

            ViewBag.Number = number;

            return View();
        }

        
    }
}
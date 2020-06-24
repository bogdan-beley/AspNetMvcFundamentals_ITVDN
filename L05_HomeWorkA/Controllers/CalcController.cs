using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L05_HomeWorkA.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int number1, int number2, string calcMethod)
        {
            int result = 0;
            switch (calcMethod)
            {
                case "+": result = number1 + number2;
                    break;
                case "-": result = number1 - number2;
                    break;
                case "*": result = number1 * number2;
                    break;
                case "/": result = number1 / number2;
                    break;
                default:
                    break;
            }

            ViewBag.result = result;

            return View();
        }
    }
}
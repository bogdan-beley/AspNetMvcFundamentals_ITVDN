using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace L02_HomeWorkA.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Add(int? x, int? y)
        {
            ViewBag.AddResult = x + y;

            return View();
        }

        public ActionResult Mul(int? x, int? y)
        {
            ViewBag.MulResult = x * y;

            return View();
        }

        public ActionResult Sub(int? x, int? y)
        {
            ViewBag.SubResult = x - y;

            return View();
        }

        public ActionResult Div(int? x, int? y)
        {
            ViewBag.DivResult = x / y;

            return View();
        }
    }
}
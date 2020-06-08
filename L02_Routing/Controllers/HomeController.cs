using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L02_Routing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Variable = RouteData.Values["id"];
            return View();
        }

        public ActionResult CustomVariable(int? id)
        {
            ViewBag.Variable = id;
            return View("Index");
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult SegmentVariables(int? x, int? y)
        {
            ViewBag.Variable = x + y;
            return View();
        }

        public ActionResult CatchAllSegments()
        {
            ViewBag.Id = RouteData.Values["Id"];
            ViewBag.CatchAll = RouteData.Values["CatchAll"];

            return View();
        }

        public ActionResult ActionLink()
        {
            return View();
        }
    }
}
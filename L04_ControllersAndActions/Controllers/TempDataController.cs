using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L04_ControllersAndActions.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Action1()
        {
            TempData["info"] = "Hello world from Action1";
            return View();
        }

        public ActionResult Action2()
        {
            string info = TempData.Peek("info") as string;
            return View((object)info);
        }

        public ActionResult Action3()
        {
            string info = TempData["info"] as string;
            return View((object)info);
        }
    }
}
using L08_HomeWorkA.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L08_HomeWorkA.Controllers
{
    public class HomeController : Controller
    {
        [ActionMethodExecutionTime]
        public ActionResult Index()
        {
            return View();
        }

        
    }
}
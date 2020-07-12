using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace L08_FiltersAndAuthorization.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivideByZeroError")]
        public ActionResult HandleError()
        {
            int a = 5;
            int b = 0;

            int result = a / b;

            return Content(result.ToString());
        }

        [MyActionFilter]
        public ActionResult ActionFilterCookiesCheck()
        {
            return View();
        }

        [ProfileAttribute]
        public ActionResult ActionFilterSlowAction()
        {
            Thread.Sleep(5000);

            return View();
        }



       
    }
}
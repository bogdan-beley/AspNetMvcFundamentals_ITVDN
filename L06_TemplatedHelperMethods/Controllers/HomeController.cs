using L06_TemplatedHelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L06_TemplatedHelperMethods.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Product p = new Product()
            {
                ProductId = 0,
                Name = "",
                Price = 0.00M,
                IsAvailable = true
            };

            return View(p);
        }
    }
}
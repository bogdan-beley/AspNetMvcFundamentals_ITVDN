using L05_HtmlHelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L05_HtmlHelperMethods.Controllers
{
    public class WebGridController : Controller
    {
        // GET: WebGrid
        public ActionResult Index()
        {
            return View(ProductsDatabase.Products);
        }
    }
}
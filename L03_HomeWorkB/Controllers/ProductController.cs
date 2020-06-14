using L03_HomeWorkB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L03_HomeWorkB.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            products = ProductCollection.All;

            return View(products);
        }
        
        [ChildActionOnly]
        public ActionResult ProductTable(int numberOfRows = 5)
        {
            IEnumerable<Product> products = ProductCollection.All.Take(numberOfRows);
            
            return PartialView("_ProductTable", products);
        }
    }
}
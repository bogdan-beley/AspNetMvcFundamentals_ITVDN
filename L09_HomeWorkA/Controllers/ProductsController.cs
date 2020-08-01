using L09_HomeWorkA.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L09_HomeWorkA.Controllers
{
    public class ProductsController : Controller
    {
        IEnumerable<Product> data = ProductsData.Products;

        // GET: Products
        public ActionResult Index()
        {
            return View(data);
        }

        public ActionResult AjaxProductsData(int from = 1, int to = 20)
        {
            data = data.Skip(from - 1).Take(to - from + 1);
            
            return PartialView(data);
        }

        public ActionResult JsonProductsData(int from, int to)
        {
            data = data.Skip(from - 1).Take(to - from + 1);

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
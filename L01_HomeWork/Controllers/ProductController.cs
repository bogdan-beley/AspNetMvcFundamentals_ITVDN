using L01_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L01_HomeWork.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "Apple",
                Price = 100,
                Description = "Green apples."
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "Bananas",
                Price = 100,
                Description = "Ripe bananas."
            });

            products.Add(new Product()
            {
                Id = 3,
                Name = "Potatoes",
                Price = 100,
                Description = "Big potatoes."
            });

            return View(products);
        }
    }
}
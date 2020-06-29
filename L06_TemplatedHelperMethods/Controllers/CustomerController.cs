using L06_TemplatedHelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L06_TemplatedHelperMethods.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Customer customer = new Customer()
            {
                CustomerId = 0,
                FirstName = "",
                LastName = "",
                DateOfBirth = DateTime.Now,
                IsApproved = true
            };

            return View();
        }
    }
}
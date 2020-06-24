using L05_HtmlHelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L05_HtmlHelperMethods.Controllers
{
    public class HtmlFormSampleController : Controller
    {
        // GET: HtmlFormSample
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateEntry()
        {
            ReturnEntry model = new ReturnEntry()
            {
                CreatedTime = DateTime.Now.ToString("dd/MM/yy HH:mm"),
                Customer = "",
                Quantity = 1,
                DeliveredBy = "",
                ReceivedBy = "",
                IsCreated = true

            };

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateEntry(ReturnEntry incommingData)
        {
            Debug.WriteLine("Created Time = " + incommingData.CreatedTime);
            Debug.WriteLine("Customer = " + incommingData.Customer);
            Debug.WriteLine("Quantity = " + incommingData.Quantity);
            Debug.WriteLine("Delivered by = " + incommingData.DeliveredBy);
            Debug.WriteLine("Received by = " + incommingData.ReceivedBy);
            Debug.WriteLine("Is created = " + incommingData.IsCreated);
            
            return PartialView("_CreatedSuccessful");
        }
    }
}
using L06_HomeWorkB2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L06_HomeWorkB2.Controllers
{
    public class ReportsController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SalesReport()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SalesReport(Report incommingData)

        {
            var orders = db.Orders.Where(o => o.PurchaseDate >= incommingData.FromDate
            && o.PurchaseDate <= incommingData.ToDate);

            return PartialView("_Orders", orders.ToList());
        }

        public ActionResult UsersReport()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UsersReport(Report incommingData)

        {
            var orders = db.Orders.Where(o =>
                o.User.FirstName == incommingData.Search 
                || o.User.LastName == incommingData.Search);

            return PartialView("_Orders", orders.ToList());
        }
    }
}
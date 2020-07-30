using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using L09_AjaxInMvc.Models;

namespace L09_AjaxInMvc.Controllers
{
    public class Json_OrdersController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Json_Orders
        public ActionResult Index()
        {
            return View();
        }

        // POST: Json_Orders/Id
        [HttpPost]
        public ActionResult Index(string id)
        {
            return View("Index", (object)id);
        }

        public ActionResult OrdersData(string id)
        {

            IEnumerable<Order> data = db.Orders;
            if (!string.IsNullOrEmpty(id) && id != "All")
            {
                data = data.Where(e => e.Product == id);
            }

            Thread.Sleep(2000);

            return PartialView(data);
        }

        // GET: Json_Orders/Json_OrdersData/Id
        public ActionResult Json_OrdersData(string id)
        {

            IEnumerable<Order> data = db.Orders;
            if (!string.IsNullOrEmpty(id) && id != "All")
            {
                data = data.Where(e => e.Product == id);
            }

            Thread.Sleep(2000);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        // GET: Json_Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Json_Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Json_Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Product,Quantity,Sum,OrderDate")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(order);
        }

        // GET: Json_Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Json_Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Product,Quantity,Sum,OrderDate")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        // GET: Json_Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Json_Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

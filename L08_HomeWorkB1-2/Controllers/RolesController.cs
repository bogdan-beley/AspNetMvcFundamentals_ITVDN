using L08_HomeWorkB1_2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace L08_HomeWorkB1_2.Controllers
{
    [Authorize]
    public class RolesController : Controller
    {
        public RolesController() { }

        private ApplicationUserManager _userManager;

        public RolesController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        private ApplicationRoleManager RoleManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationRoleManager>();
            }
        }

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Roles
        public ActionResult Index()
        {
           var roles = db.Roles.OrderBy(r => r.Name).ToList();
            
            return View(roles);
}

        // GET: Roles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                db.Roles.Add(new IdentityRole
                {
                    Name = collection["RoleName"]
                });

                db.SaveChanges();

                ViewBag.ResultMessage = "Role created succesfully!";

                return View();

            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: Roles/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            IdentityRole role = db.Roles.Find(id);
            if (role == null)
            {
                return HttpNotFound();
            }

            return View(role);
        }

        // POST: Roles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IdentityRole role)
        {
            db.Entry(role).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Roles/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            IdentityRole role = db.Roles.Find(id);
            if (role == null)
            {
                return HttpNotFound();
            }

            db.Roles.Remove(role);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Roles/UserList
        public ActionResult UserList()
        {
            var userList = UserManager.Users.ToList();

            return View(userList);
        }

        // GET: Roles/ManageUserRoles
        public ActionResult ManageUserRoles(string userId)
        {
            ApplicationUser user = UserManager.FindById(userId);
            RoleManager.Create(new ApplicationRole()
            {
                Name = "Test",

            });
            if (user != null)
            {
                var userRoles = UserManager.GetRoles(user.Id);
                var allRoles = RoleManager.Roles.ToList();
                
                foreach (var role in allRoles)
                {
                    Debug.WriteLine(role);
                }

                ChangeRoleViewModel model = new ChangeRoleViewModel()
                {
                    UserEmail = user.Email,
                    UserId = user.Id,
                    UserRoles = userRoles,
                    AllRoles = allRoles
                };

                return View(model);
            }

            return HttpNotFound();
        }

        // POST: Roles/ManageUserRoles
        [HttpPost]
        public ActionResult ManageUserRoles(string userId, List<string> roles)
        {
            ApplicationUser user = UserManager.FindById(userId);
            if (user != null)
            {
                var userRoles = UserManager.GetRoles(user.Id);
                var allRoles = RoleManager.Roles.ToList();

                var addedRoles = roles.Except(userRoles).ToArray();
                var removedRoles = userRoles.Except(roles).ToArray();

                UserManager.AddToRoles(user.Id, addedRoles);
                UserManager.RemoveFromRoles(user.Id, removedRoles);

                return RedirectToAction("UserList");
            }
            return HttpNotFound();
        }

        public ActionResult Roles()
        {
            return View(RoleManager.Roles);
        }
    }
}
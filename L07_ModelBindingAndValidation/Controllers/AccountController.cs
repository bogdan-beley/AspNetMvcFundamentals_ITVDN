using L07_ModelBindingAndValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L07_ModelBindingAndValidation.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(Account model)
        {
            if(string.IsNullOrEmpty(model.Login))
            {
                ModelState.AddModelError("Login", "Введіть логін");
            }

            if(string.IsNullOrEmpty(model.Password))
            {
                ModelState.AddModelError("Password", "Введіть пароль");
            }

            if(string.Compare(model.Password, model.PasswordConfirm) != 0)
            {
                ModelState.AddModelError("PasswordConfirm", "Паролі не збігаються");
            }

            if(string.IsNullOrEmpty(model.Email))
            {
                ModelState.AddModelError("Email", "Введіть Email");
            }

            if(ModelState.IsValid)
            {
                //Save model

                return View("Success");
            }
            else
            {
                return View();
            }
        }
    }
}
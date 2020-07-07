using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L07_ModelBindingAndValidation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ArrayBinding()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ArrayBinding(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Debug.WriteLine(numbers[i]);
            }

            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            string fileName = Guid.NewGuid().ToString();
            string extension = Path.GetExtension(file.FileName);
            fileName += extension;

            List<string> extensions = new List<string>() { ".txt", ".jpg", ".pdf", ".doc" };

            if(extensions.Contains(extension))
            {
                file.SaveAs(Server.MapPath("/Uploads/" + fileName));
                ViewBag.Message = "Файл успішно відправлено.";
            }
            else
            {
                ViewBag.Message = "Помилка. Допустимі розширення файлів: '.txt', '.jpg', '.pdf', '.doc'";
            }
            
            return View();
        }
    }
}
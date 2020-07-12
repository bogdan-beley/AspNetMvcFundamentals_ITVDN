using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace L08_HomeWorkA.Filters
{
    public class ActionMethodExecutionTimeAttribute : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string[] message = new string[] { filterContext.ActionDescriptor.ActionName, DateTime.Now.ToString() };

            File.WriteAllLines(HostingEnvironment.MapPath("~/App_Data/test.txt"), message);
        }
    }
}
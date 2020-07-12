using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L08_FiltersAndAuthorization
{
    public class ProfileAttribute : FilterAttribute, IActionFilter
    {
        private Stopwatch sw = new Stopwatch();

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            sw.Start();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            sw.Stop();

            string message = string.Format("На виконання методу {0} затрачено {1}", 
                filterContext.ActionDescriptor.ActionName, sw.Elapsed);

            sw.Reset();

            filterContext.HttpContext.Response.Write(message);
        }
    }
}
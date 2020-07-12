using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace L08_FiltersAndAuthorization
{
    public class MyActionFilterAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if(filterContext.HttpContext.Request.Cookies["test"] == null)
            {
                filterContext.Result = new HttpNotFoundResult();
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
           
        }
    }
}
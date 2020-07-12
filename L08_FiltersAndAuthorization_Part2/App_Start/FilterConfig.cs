using System.Web;
using System.Web.Mvc;

namespace L08_FiltersAndAuthorization_Part2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

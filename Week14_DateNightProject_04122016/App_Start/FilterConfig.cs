using System.Web;
using System.Web.Mvc;

namespace Week14_DateNightProject_04122016
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

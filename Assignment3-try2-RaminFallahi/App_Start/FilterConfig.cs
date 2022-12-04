using System.Web;
using System.Web.Mvc;

namespace Assignment3_try2_RaminFallahi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

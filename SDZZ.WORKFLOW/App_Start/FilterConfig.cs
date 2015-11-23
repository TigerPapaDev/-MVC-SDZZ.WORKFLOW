using System.Web;
using System.Web.Mvc;

namespace SDZZ.WORKFLOW
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
using file_manager_app.Filters;
using System.Web;
using System.Web.Mvc;

namespace file_manager_app
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new FileManagerFilter());
        }
    }
}

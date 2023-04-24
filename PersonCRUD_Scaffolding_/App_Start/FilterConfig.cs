using System.Web;
using System.Web.Mvc;

namespace PersonCRUD_Scaffolding_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace XCare.DMS.Receiving.Api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
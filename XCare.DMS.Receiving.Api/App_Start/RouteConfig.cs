using System.Web.Mvc;
using System.Web.Routing;

namespace XCare.DMS.Receiving.Api
{
    /// <summary>
    /// 
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new {controller = "Jbxx", action = "Get", id = UrlParameter.Optional}
                );
        }
    }
}
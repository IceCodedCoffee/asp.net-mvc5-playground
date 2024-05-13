using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("NamespacePriorityRoute1", "Home/{action}", new { controller = "Home" }, new[] { "URLsAndRoutes.AdditionalControllers"});
            
            routes.MapRoute("NamespacePriorityRoute2", "{controller}/{action}", new { controller = "Home", action = "Index"}, new[] { "URLsAndRoutes.Controllers"});
        }
    }
}
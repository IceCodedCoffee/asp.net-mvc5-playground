using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("MyRoute", "{controller}/{action}", 
                new { controller = "Home", action = "Index"}, 
                new { controller = "^H.*", action = "^Index$|^About$", httpMethod = new HttpMethodConstraint("GET") }
            );
        }
    }
}
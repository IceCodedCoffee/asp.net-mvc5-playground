using System.Web.Mvc;

namespace AdvancedRouting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Home";

            ViewBag.Action = "Index";

            return View("ActionName");
        }

        public ActionResult CustomVariables()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "CustomVariables";
            ViewBag.CustomVariableId = RouteData.Values["id"];
            ViewBag.CustomCatchallVariable = RouteData.Values["catchall"];

            return View();
        }
    }
}
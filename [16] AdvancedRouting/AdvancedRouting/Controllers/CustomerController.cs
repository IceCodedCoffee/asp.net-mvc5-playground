using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    [RoutePrefix("Users")]
    public class CustomerController : Controller
    {
        [Route("~/Test")]
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";

            return View("ActionName");
        }

        [Route("Add/{user}/{id:int}")]
        public string Create(string user, int id)
        {
            return $"User: {user}, ID: {id}";
        }

        [Route("Add/{user}/{password:alpha:length(6)}")]
        public string ChangePass(string user, string password)
        {
            return $"ChangePass Method - User: {user}, Pass: {password}";
        }

        public ActionResult List()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "List";

            return View("ActionName");
        }
    }
}
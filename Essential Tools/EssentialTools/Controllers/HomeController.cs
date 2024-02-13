using EssentialTools.Models;
using EssentialTools.Models.Interfaces;
using System.Web.Mvc;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private IShoppingContainer container;

        private Product[] products =
        {
             new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
             new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
             new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
             new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };

        public HomeController(IShoppingContainer containerParam)
        {
            container = containerParam;
        }

        public ActionResult Index()
        {
            container.Products = products;

            decimal totalValue = container.CalculateProductTotal();

            return View(totalValue);
        }
    }
}
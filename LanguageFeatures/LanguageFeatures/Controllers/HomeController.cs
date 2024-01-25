using LanguageFeatures.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        public ViewResult AutoProperty()
        {
            Product product = new Product();

            product.Name = "Kayak";

            product.ProductID = 1;

            string productName = product.Name;

            return View("Result", (object)String.Format($"Product name: {productName}"));
        }

        public ViewResult CreateProduct()
        {
            Product product2 = new Product
            {
                ProductID = 100,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 275M,
                Category = "Watersports"
            };

            return View("Result", (object)String.Format($"Category: {product2.Category}"));
        }

        public ViewResult CreateCollection()
        {
            string[] stringArray =
            {
                "apple",
                "orange",
                "plum"
            };

            List<int> intList = new List<int>
            {
                10,
                20,
                30,
                40
            };

            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                { "apple", 10 },
                { "orange", 20 },
                { "plum", 30 }
            };

            return View("Result", (object)stringArray[1]);
        }

        public ViewResult UseExtensionOnClass()
        {
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product>
                {
                     new Product {Name = "Kayak", Price = 275M},
                     new Product {Name = "Lifejacket", Price = 48.95M},
                     new Product {Name = "Soccer ball", Price = 19.50M},
                     new Product {Name = "Corner flag", Price = 34.95M}
                }
            };

            decimal cartTotal = cart.TotalPricesOnClass();

            return View("Result", (object)String.Format($"Total: {cartTotal:c}"));
        }

        public ViewResult UseExtensionOnInterface()
        {
            IEnumerable<Product> products = new ShoppingCart
            {
                Products = new List<Product>
                {
                     new Product {Name = "Kayak", Price = 275M},
                     new Product {Name = "Lifejacket", Price = 48.95M},
                     new Product {Name = "Soccer ball", Price = 19.50M},
                     new Product {Name = "Corner flag", Price = 34.95M}
                }
            };

            Product[] productArray =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            decimal cartTotal = products.TotalPricesOnInterface();
            decimal arrayTotal = productArray.TotalPricesOnInterface();

            return View("Result", (object)String.Format($"Cart Total: {cartTotal}, Array Total: {arrayTotal}"));
        }

        public ViewResult UseFilterExtensionMethod()
        {
            IEnumerable<Product> products = new ShoppingCart
            {
                Products = new List<Product> 
                {
                     new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
                     new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                     new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
                     new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
                }
            };

            decimal total = 0;

            foreach (Product prod in products.FilterByCategory("Soccer"))
            {
                total += prod.Price;
            }

            return View("Result", (object)String.Format($"Total: {total}"));
        }
    }
}
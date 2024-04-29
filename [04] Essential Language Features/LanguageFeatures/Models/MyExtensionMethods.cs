using System;
using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPricesOnClass(this ShoppingCart cartParam)
        {
            decimal total = 0;

            foreach (Product prod in cartParam.Products)
            {
                total += prod.Price;
            }

            return total;
        }

        public static decimal TotalPricesOnInterface(this IEnumerable<Product> productEnum)
        {
            decimal total = 0;

            foreach (Product prod in productEnum)
            {
                total += prod.Price;
            }

            return total;
        }

        public static IEnumerable<Product> FilterByCategory(this IEnumerable<Product> productEnum, string categoryParam)
        {
            foreach (Product prod in productEnum)
            {
                if (prod.Category == categoryParam)
                {
                    yield return prod;
                }
            }
        }

        public static IEnumerable<Product> LambdaFilter(this IEnumerable<Product> productEnum, Func<Product, bool> selectorParam)
        {
            foreach (Product prod in productEnum)
            {
                if (selectorParam(prod))
                {
                    yield return prod;
                }
            }
        }
    }
}
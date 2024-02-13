using EssentialTools.Models.Interfaces;
using System.Collections.Generic;

namespace EssentialTools.Models
{
    public class ShoppingCart : IShoppingContainer
    {
        private IValueCalculator calc;

        public ShoppingCart(IValueCalculator calcParam, IValueCalculator calc2)
        {
            calc = calcParam;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}
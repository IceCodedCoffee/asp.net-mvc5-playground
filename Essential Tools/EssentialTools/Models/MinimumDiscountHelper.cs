using EssentialTools.Models.Interfaces;
using System;

namespace EssentialTools.Models
{
    public class MinimumDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            if (totalParam > 100)
            {
                return totalParam * (decimal)0.9;
            }

            else if (totalParam >= 10 && totalParam <= 100)
            {
                return totalParam - 5;
            }

            else if (totalParam < 10 && totalParam >= 0)
            {
                return totalParam;
            }

            else 
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
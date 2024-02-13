using System.Collections.Generic;

namespace EssentialTools.Models.Interfaces
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}
using System.Collections.Generic;

namespace EssentialTools.Models.Interfaces
{
    public interface IShoppingContainer
    {
        IEnumerable<Product> Products { get; set; }

        decimal CalculateProductTotal();

    }
}

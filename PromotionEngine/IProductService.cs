using System.Collections.Generic;

namespace PromotionEngine
{
    public interface IProductService
    {
        int GetTotalPrice(List<Product> products);
    }
}
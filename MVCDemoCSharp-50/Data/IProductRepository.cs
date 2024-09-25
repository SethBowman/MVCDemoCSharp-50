using MVCDemoCSharp_50.Models;

namespace MVCDemoCSharp_50.Data;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
}
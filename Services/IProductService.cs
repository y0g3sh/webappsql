using webappwithsqldb.Models;

namespace webappwithsqldb.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}

using Service_Prj.Models;

namespace Service_Prj.Services
{
    public interface IProductServices
    {
        IEnumerable<Product> GetAllProducts();
        Product? GetProductById(int id);
    }
}

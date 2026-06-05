using Service_Prj.Models;

namespace Service_Prj.Services
{
    public class ProductServices : IProductServices
    {
        private readonly List<Product> _products = new()
        {
            new Product
            {
                Id = 1,
                Name = "Laptops",
                Description = "High Performance 512 GB SSD with 16GB Ram",
                Price = 78000,
                Category="Electronics",
                StockQty = 20,
                ImageUrl = "~/Images/Laptops.jpg",
                CreatedDate = DateTime.Now.AddMonths(-3),
                IsActive = true,
            },
            new Product
            {
                Id = 2,
                Name = "Head Phones",
                Description = "Noise-cancelling over-ear with Bluetooth Connectivity",
                Price = 6800,
                Category="Accessories",
                StockQty = 25,
                ImageUrl = "~/Images/Hphones.jpg",
                CreatedDate = DateTime.Now.AddMonths(-6),
                IsActive = true,
            },
            new Product
            {
                Id = 3,
                Name = "Smart Phones",
                Description = "Latest Model with OLED display and pixel quality",
                Price = 35000,
                Category="Electronics",
                StockQty = 30,
                ImageUrl = "~/Images/SmartPhones.jpg",
                CreatedDate = DateTime.Now.AddMonths(-1),
                IsActive = true,
            },
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}

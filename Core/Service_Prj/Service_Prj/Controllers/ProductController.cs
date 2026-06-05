using Microsoft.AspNetCore.Mvc;
using Service_Prj.Services;

namespace Service_Prj.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _productservices;

        public ProductController(IProductServices productservices)
        {
            _productservices = productservices;
        }
        public IActionResult Index()
        {
            var products = _productservices.GetAllProducts();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = _productservices.GetProductById(id);
            if (product == null)
                return NotFound();
            return View(product);
        }

    }
}

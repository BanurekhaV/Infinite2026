using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViews_Prj.Models;

namespace PartialViews_Prj.Controllers
{
    public class ProductController : Controller
    {
        List<Product> productlist;

        public ProductController()
        {
            productlist = new List<Product>()
            {
                new Product{ProductId=1, ProductName="Shoes", Category="Accessories",
                ProductDescription="Smooth Soles for Comfort", Price=3500},
                new Product{ProductId=2, ProductName="Watches", Category="Accessories",
                ProductDescription="Smart and User Friendly", Price=6500},
                new Product{ProductId=3, ProductName="Curtains", Category="Furnishings",
                ProductDescription="Valence Curtains for Elegance", Price=4500},
                new Product{ProductId=4, ProductName="Pillows", Category="Beddings",
                ProductDescription="Latex Foam for No Pain", Price=3000},
            };
        }
        // GET: Product
        public ActionResult Index()
        {
            return View(productlist);
        }

        //partial view action method
        public PartialViewResult GetAllProducts()
        {
            List<Product> prdlist = new List<Product>()
            {
                new Product{ProductId=1, ProductName="Shoes", Category="Accessories",
                ProductDescription="Smooth Soles for Comfort", Price=3500},
                new Product{ProductId=2, ProductName="Watches", Category="Accessories",
                ProductDescription="Smart and User Friendly", Price=6500},
                new Product{ProductId=3, ProductName="Curtains", Category="Furnishings",
                ProductDescription="Valence Curtains for Elegance", Price=4500},
                new Product{ProductId=4, ProductName="Pillows", Category="Beddings",
                ProductDescription="Latex Foam for No Pain", Price=3000},
            };
            return PartialView("ProductDetails", prdlist);
        }

        //normal method that takes up the list of products
        public ActionResult JustNormalMethod()
        {
           // return View(productlist);
            return View();
        }
    }
}
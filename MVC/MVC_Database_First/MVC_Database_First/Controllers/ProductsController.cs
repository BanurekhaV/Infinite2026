using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Database_First.Models;
using System.Data.Entity;

namespace MVC_Database_First.Controllers
{
    public class ProductsController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        // GET: Products
        public ActionResult Index()
        {
            //we will use the concept of eager loading of the category and supplier models along with product model
            var products = db.Products.Include(P1 => P1.Category).Include(P1 => P1.Supplier);
            return View(products.ToList());
        }

        //1. Adding a product
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //for the category and supplier dropdowns
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName",product.CategoryID);
            ViewBag.SupplierID = new SelectList(db.Suppliers, "SupplierID", "CompanyName",product.SupplierID);
            return View(product);
        }
    }
}
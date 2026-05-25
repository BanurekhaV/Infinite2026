using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CodeFirst.Models;
using MVC_CodeFirst.Repository;
using System.Net;

namespace MVC_CodeFirst.Controllers
{
    public class ProductsController : Controller
    {
        IRepository<Products> _productsRepository = null;

        //controller constructor

        public ProductsController()
        {
            _productsRepository = new ConcreteRepo<Products>();
        }

        // GET: Products
        //1. Get all products
        public ActionResult Index()
        {
            var prod = _productsRepository.GetAll();
            return View(prod);
        }

        //2. create a new Product
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Products prod)
        {
            if(ModelState.IsValid)
            {
                _productsRepository.Insert(prod);
                _productsRepository.Save();
                return RedirectToAction("Index");   
            }
            return View(prod);
        }

        public ActionResult Details(int ? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var prod = _productsRepository.GetByID(id);

            if(prod==null)
            {
                return HttpNotFound();
            }
            return View(prod);
        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_EF.Models;

namespace WebAPI_EF.Controllers
{
    public class ProductController : ApiController
    {
        InfiniteDBEntities1 db = new InfiniteDBEntities1();

        //Get : api/Product
        public IQueryable<Product> GetProducts()
        {
            return db.Products;
        }

        public IHttpActionResult GetProductById(int id)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        public IHttpActionResult Put(Product product)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            try
            {
                db.SaveChanges();
            }
            catch(DbUpdateConcurrencyException)
            {

            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult PostProduct([FromBody]Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Validations Failed");               
            }
            db.Products.Add(new Product()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Price = product.Price,
                QuantityAvailable = product.QuantityAvailable
            });
            db.SaveChanges();
            return Ok("Success");
        }

        public IHttpActionResult Delete(int id)
        {
            Product p = db.Products.Find(id);
            if(p == null)
            {
                return NotFound();
            }
            db.Products.Remove(p);
            db.SaveChanges();
            return Ok(p);
        }
    }
}

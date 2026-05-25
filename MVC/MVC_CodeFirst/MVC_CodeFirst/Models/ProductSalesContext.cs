using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_CodeFirst.Models
{
    public class ProductSalesContext : DbContext
    {
        public ProductSalesContext() : base("name = connectstr"){ }

        public DbSet<Products>Products { get; set; }
        public DbSet<Sales>Sales { get; set; }
    }
}
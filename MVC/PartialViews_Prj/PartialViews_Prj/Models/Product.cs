using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViews_Prj.Models
{
    public class Product
    {
        public long ProductId {  get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Category {  get; set; }
        public decimal Price { get; set; }
    }
}
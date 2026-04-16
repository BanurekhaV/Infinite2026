using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_with_Unity.Concrete
{
    internal class ProductClass : IProducts
    {
        public string InsertProducts()
        {
            string str = "DI Injected Successfully...";
            Console.WriteLine(str);
            return str;
        }

        public void ShowProducts()
        {
            Console.WriteLine("No Products");
        }
    }
}

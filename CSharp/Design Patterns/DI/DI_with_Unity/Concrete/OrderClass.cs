using DI_with_Unity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_with_Unity.Concrete
{
    internal class OrderClass : IOrders
    {
        public void DisplayOrders()
        {
            Console.WriteLine("These are the List of Orders...");
        }
    }

}

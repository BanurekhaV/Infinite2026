using DI_with_Unity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_with_Unity.BL
{
    internal class BusinessClass
    {
        IOrders _orders;
        IProducts _products;

        public BusinessClass(IOrders orders, IProducts products)
        {
            _orders = orders;
            _products = products;
        }

        public void Insert()
        {
            _products.InsertProducts(); // this call is actually invoking the productclass InsertProducts()
        }

        public void ShowOrders()
        {
            _orders.DisplayOrders(); // this call is actually invoking the DisplayOrders() of orderclass
        }
    }
}

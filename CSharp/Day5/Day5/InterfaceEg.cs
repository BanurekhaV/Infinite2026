using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    interface IOrders
    {
        int NoOfOrders();
    }
    interface ISupplier : IOrders
    {
        void Print();
    }
    interface ICustomer : ISupplier
    {
        void ListofGoods();  //only declaration                           
    }

    class Customer : ICustomer
    {
        public void ListofGoods()
        {
            Console.WriteLine("This is the List of Goods from ICustomer..");
        }

        public void Print()
        {
            Console.WriteLine("Printing ISuppliers List of Goods..");
        }

        public int NoOfOrders()
        {
            return 100;
        }
    }
    
    internal class InterfaceEg
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(); //implementing class object
            customer.ListofGoods();
            customer.Print();
            customer.NoOfOrders();            
            Console.Read();
        }
    }
}

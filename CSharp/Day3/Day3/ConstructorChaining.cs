using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Customer
    {
        int age;
        string custname;
        int custrating;
        public Customer():this(45)
        {
            custrating = 4;           
        }
        public Customer(int c) : this("Bob", 3)
        {
            age = c;            
        }

        public Customer(string s, int x) 
        {
            custname = s;
            custrating = x;            
        }

        public void showdata()
        {
            Console.WriteLine(custname + " " + age + " " + custrating);
        }
    }
    internal class ConstructorChaining
    {
        static void Main()
        {
             Customer customer = new Customer("Cust",15);
            customer.showdata();
            Console.WriteLine("-------------------");
            Customer cust = new Customer();
            cust.showdata();
            Console.WriteLine("---------------------");
            Customer cust3 = new Customer(5);
            cust3.showdata();
            Console.Read();
        }
    }
}

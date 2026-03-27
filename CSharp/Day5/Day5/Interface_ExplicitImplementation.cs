using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    interface IAccounts
    {
        void InterfaceMethod();
    }

    interface IBooks
    {
        void InterfaceMethod();
    }

    internal class Interface_ExplicitImplementation : IAccounts, IBooks
    {
         public void InterfaceMethod()
         {
            Console.WriteLine("IAccounts Interface Method.");
         }

        void IBooks.InterfaceMethod()
        {
            Console.WriteLine("IBooks Interface Method.");
        }

        static void Main()
        {
            Interface_ExplicitImplementation ie = new Interface_ExplicitImplementation();
            
            //to make one interface method as default, then remove the explicit implementation and make 
            //the method public. Then we can access the method with the implementing class object

            ie.InterfaceMethod();

            Console.WriteLine("--------------------------");
            // Option 1 to call the explicit methods (2 nos)

            ((IAccounts)ie).InterfaceMethod();
            ((IBooks)ie).InterfaceMethod();

            Console.WriteLine("***************************");
            //option 2
            IAccounts accts = new Interface_ExplicitImplementation();
            accts.InterfaceMethod();

            IBooks books = new Interface_ExplicitImplementation();
            books.InterfaceMethod();
            Console.Read();
        }
    }
}

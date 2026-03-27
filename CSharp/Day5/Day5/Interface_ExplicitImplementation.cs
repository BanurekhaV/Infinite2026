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

        }
        
    }
}

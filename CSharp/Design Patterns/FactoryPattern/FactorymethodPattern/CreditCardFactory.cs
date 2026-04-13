using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorymethodPattern.Interfaces;

namespace FactorymethodPattern
{  

    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeCards();

        public CreditCard CreateCard()
        {
            return this.MakeCards();
        }
    }
}

using FactorymethodPattern.Interfaces;
using FactorymethodPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorymethodPattern.Implementations
{
    internal class MoneybackFactory : CreditCardFactory
    {
        protected override CreditCard MakeCards()
        {
            CreditCard card = new MoneyBack();
            return card;
        }
    }
}

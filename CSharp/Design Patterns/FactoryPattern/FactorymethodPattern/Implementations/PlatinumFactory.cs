using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorymethodPattern.Interfaces;
using FactorymethodPattern.Products;

namespace FactorymethodPattern.Implementations
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeCards()
        {
            CreditCard card = new Platinum();
            return card;
        }
    }
}

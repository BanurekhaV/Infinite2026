using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Implementors
{
    internal class MoneyBack : CreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack Card";
        }

        public int GetCardLimit()
        {
            return 15000;
        }

        public int GetAnnualCharges()
        {
            return 500;
        }
    }
}

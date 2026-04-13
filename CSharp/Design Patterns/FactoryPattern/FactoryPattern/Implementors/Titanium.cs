using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Implementors
{
    internal class Titanium : CreditCard
    {
        public string GetCardType()
        {
            return "Titanium Card";
        }

        public int GetCardLimit()
        {
            return 25000;
        }


        public int GetAnnualCharges()
        {
            return 1500;
        }
    }
}

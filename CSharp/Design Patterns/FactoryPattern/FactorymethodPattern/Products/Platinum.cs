using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorymethodPattern.Interfaces;

namespace FactorymethodPattern.Products
{
    internal class Platinum : CreditCard
    {
        public string GetCardType()
        {
            return "Platinum Card";
        }

        public int GetCardLimit()
        {
            return 35000;
        }


        public int GetAnnualCharges()
        {
            return 2500;
        }
    }
}

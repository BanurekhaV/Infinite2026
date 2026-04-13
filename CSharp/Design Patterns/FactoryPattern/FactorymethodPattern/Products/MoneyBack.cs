using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorymethodPattern.Interfaces;


namespace FactorymethodPattern.Products
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

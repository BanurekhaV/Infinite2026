using FactorymethodPattern.Implementations;
using FactorymethodPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorymethodPattern.Products;

namespace FactorymethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = new PlatinumFactory().CreateCard();
            if(card!=null)
            {
                Console.WriteLine($"CardType : {card.GetCardType()}");
                Console.WriteLine($"CardLimit : {card.GetCardLimit()}");
                Console.WriteLine($"CardAnnual Charges : {card.GetAnnualCharges()}");
            }
            Console.Read();
        }
    }
}

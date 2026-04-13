using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Implementors;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = null;
            Console.WriteLine("Enter Card Type :");
            string cardType = Console.ReadLine();
            card = CreditCardFactory.GetCreditCard(cardType);
            
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


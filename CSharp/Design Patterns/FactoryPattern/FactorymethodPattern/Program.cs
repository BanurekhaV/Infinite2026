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
            Console.WriteLine("Enter the Card type");
            string cardType = Console.ReadLine();

            CreditCard card = new PlatinumFactory().CreateCard();
        }
    }
}

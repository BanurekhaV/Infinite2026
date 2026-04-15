using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Products
{
    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Getting the Details of Regular Bike ...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Products
{
    public class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Getting the Details of Regular Car ...");
        }
    }
}

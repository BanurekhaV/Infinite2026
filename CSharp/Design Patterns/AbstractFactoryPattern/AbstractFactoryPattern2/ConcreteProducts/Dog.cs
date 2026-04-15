using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern2.ConcreteProducts
{
    internal class Dog : IAnimal
    {
        public string Speak()
        {
            return "Bow Bow";
        }
    }
}

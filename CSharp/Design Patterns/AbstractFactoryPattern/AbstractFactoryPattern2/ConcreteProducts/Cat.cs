using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern2.ConcreteProducts
{
    internal class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow Meow";
        }
    }
}

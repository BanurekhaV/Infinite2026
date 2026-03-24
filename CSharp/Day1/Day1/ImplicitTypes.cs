using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class ImplicitTypes
    {
        public void UnderstandImplicitTypes()
        {
            int x;
            x = 5;

            var v = true;

            dynamic d;
            d = 5;
            Console.WriteLine(d);
            d = 'a';
            d = 34.5f;
            Console.WriteLine(d);
            d = false;
            d = "hello";
            Console.WriteLine(d);
        }
    }
}

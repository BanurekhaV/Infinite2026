using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    internal class TypeConversion
    {
        static void Main()
        {
            Console.WriteLine("Minimum Value of integer {0} ", int.MinValue);
            Console.WriteLine("Maximum is {0} ", int.MaxValue);

            //declaring a primitive type
            int num = 100;
            Console.WriteLine("num is " +  num);
            float f = num;    // implicit conversion
            Console.WriteLine("num is " + num);
            f = 2456.55f;
            Console.WriteLine("float is " + f);
            num = (int)f;    // explicit conversion using typecasting
            Console.WriteLine("float is " + num);
            num = Convert.ToInt32(f);  // explicit conversion using function
            Console.WriteLine("float is " + num);
            Console.Read();
        }
    }
}

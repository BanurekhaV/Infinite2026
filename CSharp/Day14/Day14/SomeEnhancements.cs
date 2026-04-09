using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    internal class NamedArgs
    {
        static int Add(int x , int y = 8)  //default value given for y
        {
            Console.WriteLine("x value  : {0} and y value : {1}", x,y);
            return x + y;
        }

        //optional 
        static int Add2Nos([Optional] int y, int x)
        {
            return x + y;
        }

        static void Main()
        {
            Console.WriteLine(Add(5,10));  //normal call positional
            Console.WriteLine(Add(y:6, x:5));  // named arguments in different order
            Console.WriteLine(Add(x:7,y:5));  // named arguments  as per the order

            Console.WriteLine(Add(5, y:6)); //named argument can follow a positional argument
            // Console.WriteLine(Add(y:8,5));  //postional argument cannot follow named argument

            Console.WriteLine("--------Optional Parameters----------");
            Console.WriteLine(Add(10));  //using default value

            Console.WriteLine("----------Optional Parameters----------");
            Console.WriteLine(Add2Nos(x:20));
            Console.Read();
        }
    }
}

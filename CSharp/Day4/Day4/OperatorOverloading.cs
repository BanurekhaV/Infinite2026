using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Box
    {
        public int length;
        public int breadth;

        public static Box operator +(Box box1, Box box2)
        {
            Box temp = new Box();
            temp.length = box1.length + box2.length;
            temp.breadth = box1.breadth + box2.breadth;
            return temp;
        }
    }
    internal class OperatorOverloading
    { 
        static void Main()
        {
            int a = 5, b =5, c = 0;

            c = a + b;
            Console.WriteLine(c);

            Box b1 = new Box();
            b1.length = 5;
            b1.breadth = 3;

            Box b2= new Box();
            b2.length = 4;
            b2.breadth = 5;

            Box b3 = b1 + b2;
            Console.WriteLine($"The Total Lengths is {b3.length} and total breadth is { b3.breadth}");

             // b3++;
            Console.Read();
        }
    }
}

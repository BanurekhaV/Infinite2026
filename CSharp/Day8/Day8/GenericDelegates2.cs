using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public delegate int Arithmetic(int x, int y);
    internal class GenericDelegates2
    {
        static void Main()
        {
            DoOperation(10, 2, Multiply);
            DoOperation(10, 2, Divide);
            Console.Read();
        }

        public static void DoOperation(int x, int y, Arithmetic Adel)
        {
            int z = Adel(x,y);
            Console.WriteLine(z);
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return (x / y);
        }
    }
}

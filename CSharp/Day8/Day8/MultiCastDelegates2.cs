using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public delegate int DelOps(int x);
    internal class MultiCastDelegates2
    {
        static int p;

        public int Square(int x)
        {
            p = x * x;
            return p;
        }

        public int Triple(int x)
        {
            p = x * x * x;
            return p;
        }
    }

    class MultiCast
    {
        static void Main()
        {
            MultiCastDelegates2 md = new MultiCastDelegates2();

            DelOps doops;
            DelOps d1 = new DelOps(md.Square);
            DelOps d2 = new DelOps(md.Triple);
            Console.WriteLine(d1(5));
            Console.WriteLine(d2(5));
            Console.WriteLine("------------------");
            doops = d1 + d2;
            int result = doops(5);
            Console.WriteLine(result);

            Console.Read();


        }
    }
}

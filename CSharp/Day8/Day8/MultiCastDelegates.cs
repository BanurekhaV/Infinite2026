using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public delegate void MultiDel();
    internal class MultiCastDelegates
    {
        static void Main()
        {
            //1 st option
            //MultiDel m1, m2, m3, m4;
            // m1 = new MultiDel(Method1);
            // m2 = new MultiDel(Method2);
            // m3 = new MultiDel(Method3);
            // m4 = m1 + m2 + m3;  // use '+' sign to multicast and use '-' sign to remove
            ////or  m4 += m1; m4+=m2; m4+=m3;
            // m4();

            // m4 = m1 + m2 -m3;
            // //or m4 -= m3;
            // Console.WriteLine("------------------");
            // m4();
            // Console.WriteLine("--------------------");

            MultiDel m = new MultiDel(Method1);
            m += Method2;
            m += Method3;
            m();
            Console.WriteLine("--------------------");
            m -= Method2;
            m();
            Console.Read();
        }

        public static void Method1()
        {
            Console.WriteLine("Method 1 Invoked...");
        }
        public static void Method2()
        {
            Console.WriteLine("Method 2 Invoked...");
        }

        public static void Method3()
        {
            Console.WriteLine("Method 3 Invoked...");
        }
    }
}

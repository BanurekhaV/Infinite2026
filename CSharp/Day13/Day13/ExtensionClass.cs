using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    static class ExtensionClass
    {
        public static void M4(this Program p)
        {
            Console.WriteLine("Extension method 4..");
        }

        public static void M5(this Program p, string str)
        {
            Console.WriteLine("Extension method 5.." + " " + str);
            
        }
    }
}

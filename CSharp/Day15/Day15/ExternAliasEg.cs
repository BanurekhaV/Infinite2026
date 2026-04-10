extern alias X;
extern alias Y;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Lib1;
//using Lib2;

namespace Day15
{
    internal class ExternAliasEg
    {
        static void Main()
        {
            //Lib1.LibClass lc = new Lib1.LibClass();
            //lc.Message();
            //Lib2.LibClass lc2 = new Lib2.LibClass();
            //lc.Message();

            X.Lib1.LibClass lc = new X.Lib1.LibClass();
            lc._f = 5;
            lc.Message();

            Console.Read();
           



        }
    }
}

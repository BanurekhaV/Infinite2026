using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class ReadOnly_Constants
    {
         readonly int myvar1 = 5;  // readonly initialized at the time of declaration
         static int mystat1 = 10;  // static
         int mynonstat1 = 15;   // non static
         const int myconst = 20; //constant
         const float PI = 3.14f;

        //constructor definition
        public ReadOnly_Constants()
        {
            myvar1 = 500;           
        }
        public static void UnderstandingReadonlyConstants()
        {
            ReadOnly_Constants rc = new ReadOnly_Constants();
            Console.WriteLine("The value of myvar 1 is " + rc.myvar1 +  " and myconst is : " + myconst);

            ReadOnly_Constants rc2 = new ReadOnly_Constants();
            Console.WriteLine("The value of myvar 1 is " + rc2.myvar1 + " and myconst is : " + myconst);
        }
    }
}

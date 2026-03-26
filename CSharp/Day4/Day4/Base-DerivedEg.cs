using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class BaseClass
    {
        int bcvariable;
        //public BaseClass()   // empty constructor
        //{
        //    Console.WriteLine("This is Base class");
        //}

        public BaseClass(int a)
        {
            bcvariable = a;
            Console.WriteLine("That was base class data.." + " " + bcvariable);
        }
    }

    class SubClass : BaseClass
    {
        int scvariable;
         public SubClass(int b) : base(b)
         {
            scvariable = b;
            Console.WriteLine("This is Sub class" + " "+ scvariable); 
         }

        public SubClass(int x, int y):base(y)
        {
            scvariable = x;
            Console.WriteLine(scvariable + " subclass data");
        }
     }
    internal class Base_DerivedEg
    {
        static void Main()
        {
         // BaseClass bc = new BaseClass();
        //  BaseClass bc2 = new BaseClass(10);

          SubClass sc = new SubClass(50, 20);
          Console.Read();
        }
    }
}

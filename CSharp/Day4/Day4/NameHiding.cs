using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class A1
    {
        public int i = 0;

        public void MethodHide(string s)
        {
            Console.WriteLine("Message from Base class {0}", s);
        }
    }

    class B1 : A1
    {
       public new int i;

        public B1(int a, int b)
        {
            base.i = a;  // assignment to the i in A1
            i = b;
        }

        public new void MethodHide(string str)
        {
            Console.WriteLine("Message from Derived Class {0}", str);
        }

        public void Show()
        {
            Console.WriteLine("i in Base Class A1 is {0}", base.i);
            Console.WriteLine("i in Derived Class B1 is {0}", i);
        }
    }

    internal class NameHiding
    {
        static void Main()
        {
            B1 bobj = new B1(2, 5);
            bobj.Show();
            Console.Read();
        }
    }
}

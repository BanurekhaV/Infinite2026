using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class OverloadingEg
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public float add(int x, float y)
        { 
            return x + y;
        }

        public static void swap(int number1, int number2)
        {
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("Swapping 2 integers number 1 = " + number1 + " number 2 =" + number2);
        }

        public static void swap(char ch1, char ch2)
        {
            char temp = ' ';
            temp = ch1;
            ch1 = ch2;
            ch2 = temp;
            Console.WriteLine("Swapping 2 Characters ch1 = "+ ch1 + " " + "ch2 = "+ ch2);
        }
    }

    class TestOverload
    {
       static void Main()
        {
            OverloadingEg overloadeg = new OverloadingEg();
            overloadeg.add(5, 5);
            overloadeg.add(10, 15.55f);
            OverloadingEg.swap('a', 'z');  // goto line 29
            OverloadingEg.swap(5, 10); //goto line 21
            Console.Read();
        }
    }
}

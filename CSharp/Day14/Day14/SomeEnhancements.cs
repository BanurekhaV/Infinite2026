using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    internal class NamedArgs
    {
        static int Add(int x , int y = 8)  //default value given for y
        {
            Console.WriteLine("x value  : {0} and y value : {1}", x,y);
            return x + y;
        }

        //optional 
        static int Add2Nos([Optional] int y, int x)
        {
            return x + y;
        }

        static void Main()
        {
            Console.WriteLine(Add(5,10));  //normal call positional
            Console.WriteLine(Add(y:6, x:5));  // named arguments in different order
            Console.WriteLine(Add(x:7,y:5));  // named arguments  as per the order

            Console.WriteLine(Add(5, y:6)); //named argument can follow a positional argument
            // Console.WriteLine(Add(y:8,5));  //postional argument cannot follow named argument

            Console.WriteLine("--------Optional Parameters----------");
            Console.WriteLine(Add(10));  //using default value

            Console.WriteLine("----------Optional Parameters----------");
            Console.WriteLine(Add2Nos(x:20));

            Console.WriteLine("----Exception Filters-----");

            int[] numbers = { 1, 2, 3 };
            int index = 4;
            try
            {
                Console.WriteLine(numbers[index]);
            }
            catch(IndexOutOfRangeException ex) when (index <0)
            {
                Console.WriteLine("Negative Index not allowed..");
            }
            catch (IndexOutOfRangeException ex) when(index >=numbers.Length)
            {
                Console.WriteLine("Index is beyond the size..");
            }

            try
            {
                int num = 0;
                int x = 5 / num;
            }
            catch(DivideByZeroException ex) when(DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine("Sorry cannot handle as it is Tuesday");
            }
            catch(DivideByZeroException ex) when (DateTime.Now.DayOfWeek.Equals(DayOfWeek.Friday))
            {
                Console.WriteLine("Handled since it is thursday");
                SomeotherFunction();
            }
            catch(Exception ex) when (ex.GetType().ToString() == "System.DivideByZeroException")
            {
                Console.WriteLine("Continue, Handled..");
            }
            Console.Read();
        }

        static void SomeotherFunction()
        {
            Console.WriteLine("A new Task started to run....");
        }
    }
}

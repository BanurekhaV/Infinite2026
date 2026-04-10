using System;
using System.Collections.Generic;
using static System.Convert;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day15
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Gender { get; set; }
        public double Salary { get;  set; } 
        public string Department {  get; set; }
    }
    internal class Program
    {
        int[] arr = new int[5];   


        int ShowOp(int[] x)
        {
            x[5] = 10;
            return x[5];
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            try
            {
                p.ShowOp(p.arr);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The method that caused exception : " + nameof(p.ShowOp));
                Console.WriteLine(ex.Source + ex.StackTrace);
            }
                
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                {"Emp101", "John" },
                 {"Emp102", "Joe" },
                  {"Emp103", "Jane" },
            };

            //with C# 6.0
            Dictionary<string, string> dic2 = new Dictionary<string, string>()
            {
                ["Emp101"] = "John",
                ["Emp102"] = "Joe",
                ["Emp102"] = "Jane",
            };
            Console.Read();
        }
    }

    class ExpressionBodied
    {
        public static int year = 2016;

        // eg 2 More Options
        /// <summary>
        /// this is an eg for expr bodied method
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        public int SquareArea(int side) => side * side;
        public int Operations(int a, int b) => ((a+b) + (a-b) +  (a*b) + (a/b));
                                                 
        public double Squareroot(int x, int y) => Math.Sqrt(x*x + y*y);

        public static double Divide(int x,int y)
        {
            return y!= 0 ? x % y : throw new DivideByZeroException();
        }
        #region
        static void Main(string[] args)
        {
            Console.WriteLine(LeapYear());
            Console.WriteLine("--------More Options -------");
            ExpressionBodied eb = new ExpressionBodied();
            Console.WriteLine("Enter side :");
            int s = ToInt32(Console.ReadLine());
            Console.WriteLine(eb.SquareArea(s));  // calling expr bodied Method

            Console.WriteLine("Enter 2 nos :");
            int x = ToInt32(Console.ReadLine());
            int y = ToInt32(Console.ReadLine());

            int op = eb.Operations(x, y);

            Thread.Sleep(2000);
            Console.WriteLine("Results of the Operation is " + op);

            Console.WriteLine("--------------");
            Console.WriteLine(eb.Squareroot(x,y));

            //eg for Throws expression

            var answer = Divide(10, 0);
            Console.Read();
        }
        #endregion
        //1. with Expression bodied
        //public static string LeapYear() => "\n Is " + year + " a leap Year ?" + DateTime.IsLeapYear(year);

        //2. 

        public static string LeapYear()=>$" Is {year} a Leap Year ? " + DateTime.IsLeapYear(year);  
        // Without expression bodied 
       // public static string LeapYear()
        // {
        //return "\n Is " + year + " a leap Year ?" + DateTime.IsLeapYear(year);
        // }
    }
}

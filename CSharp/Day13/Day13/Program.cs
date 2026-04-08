using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculatordll;
using CalculatorExtensionDll;

namespace Day13
{
    internal class Program
    {
        public void M1()
        {
            Console.WriteLine("Method 1");            
        }
        public void M2()
        {
            Console.WriteLine("Method 2");
        }
        public void M3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.M1();
            program.M2();
            program.M3();
            program.M4();
            program.M5("hi");

            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(5, 5)); 
            Console.WriteLine(calculator.Subtract(6, 5));
            Console.WriteLine(calculator.Multiply(6, 5));
            Console.WriteLine(calculator.Divide(6, 2));
            Console.Read();
        }
    }
}

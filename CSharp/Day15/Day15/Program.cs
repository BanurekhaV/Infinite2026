using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; } = "Janani";
        public double Salary { get; protected set; } = 30000;
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
}

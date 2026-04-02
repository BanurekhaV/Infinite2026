using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Program
    {
        delegate void Print(int v);
        static void Main(string[] args)
        {
            int i = 100;
            Print p = delegate (int x)  // delegate calling an anonymous method
            {
                x += i;
                Console.WriteLine("We are inside an Anonymous Function Call {0}", x);
            };

            p(10);
            Console.WriteLine(" We are trying to learn anonymous functions..");
            p(5);
            Console.WriteLine("------------Example 2------------");

            int[] numbers = {1,2,3,4,5,6,7,8,9,10};

            int[] evennos = Array.FindAll(numbers, delegate (int num)
            {
                return num % 2 == 0;
            });
            Console.WriteLine("------ Even Nos ------");
            foreach(int item in evennos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------Fucntion Delegate-----------");
            Func<int,int,int> getRnumber = delegate (int n1, int n2)
            {
                
                Random rnd = new Random();
                return rnd.Next(n1, n2);
            };

            //calling func delegate 
            Console.WriteLine("Enter 2 numbers between 1 and 100");
            int c = Convert.ToInt32(Console.ReadLine());
           int d = Convert.ToInt32(Console.ReadLine());
            int randonnumber = getRnumber(c,d);
            Console.WriteLine("The generated RandommNumber is {0}", randonnumber);
            //func delegate using lambda
            Func<int> getRandomNum = () => new Random().Next(1, 100);

            Func<int, int, int> FindSum = (a, b) => a + b;

            Console.WriteLine("random number using lambda {0}", getRandomNum());
            Console.WriteLine("total is : {0}", FindSum(26,48));
            Console.Read();
        }
    }
}

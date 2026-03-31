using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Enter 2 number :");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                int[] arr = { 1, 2, 3, 4 };
                Console.WriteLine(arr[6]);
                Console.WriteLine("The value of C is " + c);

            }            
            //catch (DivideByZeroException de)
            //{
            //    Console.WriteLine(de.Message);
            //    Console.WriteLine("Cannot divide a number by Zero.. Try again");
            //}
            //catch(FormatException fe)
            //{
            //    Console.WriteLine(fe.Message + " " + fe.StackTrace);
            //}
            //catch(IndexOutOfRangeException ie)
            //{
            //    Console.WriteLine("You are trying to reach beyond your elements");
            //}
            catch (Exception e)
            {
                // Console.WriteLine("Something went wrong.. try after sometimes");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Reached Finally");
            }
            Console.Read();
        }
    }
}

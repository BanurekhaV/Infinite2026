using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main()
        {
            Program arrays = new Program();
            arrays.SingleDimension();
            Console.WriteLine("-------------------");
            arrays.TwoDimension();
            Console.Read();
        }
        public void SingleDimension()
        {
            int[] arr = new int[5] { 6, 23, 1, 45, 12 };
            Console.WriteLine("The length of the Array is {0}", arr.Length);
            Console.WriteLine("Before Sort...");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Array.Sort(arr);
            Console.WriteLine("After Sort...");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(arr.Rank);
        }
        public void TwoDimension()
        {
            int[,] myarray = new int[3, 3] { { 1, 2, 3, }, { 4, 5, 6, },{7,8,9 } };
            Console.WriteLine(myarray[1, 1]);

            //1 st loop to iterate the rows
           // for (int i = 0; i < 2; i++)
           for(int i=0;i<myarray.GetLength(0);i++)
           {
                //loop 2 for columns 
               // for (int j = 0; j < 3; j++)
               for(int j=0;j<myarray.GetLength(1);j++)
               {
                    Console.Write(myarray[i, j] + " ");
               }
                Console.WriteLine();
           }
        }
    }
}


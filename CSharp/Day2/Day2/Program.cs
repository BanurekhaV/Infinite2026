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
            Console.WriteLine("-------------------");
            arrays.JaggedArray();
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
            int[,] myarray = new int[3, 3] { { 1, 2, 3, }, { 4, 5, 6, }, { 7, 8, 9 } };
            Console.WriteLine(myarray[1, 1]);

            //1 st loop to iterate the rows
            // for (int i = 0; i < 2; i++)
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                //loop 2 for columns 
                // for (int j = 0; j < 3; j++)
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.Write(myarray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void JaggedArray()
        {
            //declare a jagged array of 2 rows
            int[][] myjagg = new int[2][];

            //let us now set the size for each array element
            myjagg[0] = new int[3];
            myjagg[1] = new int[2];

            //let u sinitialize the jagged array
            myjagg[0][0] = 2;
            myjagg[0][1] = 4;
            myjagg[0][2] = 6;

            myjagg[1][0] = 1;
            myjagg[1][1] = 3;

            //2. initializing in another way
            int[][] jagg2 =
            {
                new int[] { 5, 10, 15, 20 },
                new int[] { 25, 30 },
                new int[] { 35, 40, 45 }
            };

            //to display the elements of the above jagged array
            for (int i = 0; i < jagg2.Length; i++)
            {
                Console.WriteLine("Number of elements at Row : " + i + "is : " + jagg2[i].Length);
                //inner loop
                for(int j=0; j<jagg2[i].Length; j++)
                {
                    Console.Write(jagg2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


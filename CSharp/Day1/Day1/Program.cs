using System;
using System.CodeDom;


namespace Day1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 10;
            SimpleCallbyValue(i);
            Console.WriteLine("The value of i : {0} ",i);
            SimpleCallByRef(ref i);
            Console.WriteLine("The value of i : {0} ", i);
            int total, prod , diff = 0;
            diff = Calculator(20, 10, out total, out prod);
            Console.WriteLine($"Sum is {total}, Product is {prod} and the difference is {diff}");
            Console.WriteLine( "========Param Arrays=========");
            int totalElements = AddElements(); // calling a function with no arguments
            Console.WriteLine(  "The Sum of Elements is {0} ", totalElements);
            totalElements = AddElements(512,720,824,545); //calling a function with 4 arguments
            Console.WriteLine("The Sum of Elements is {0} ", totalElements);
            Console.WriteLine("***** Example 2 of Params *******");
            int[] num = new int[3];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;

            ParamsMethod();  //0 argument
            ParamsMethod(num);  // arraylist
            ParamsMethod(1, 2, 3, 4, 5, 6, 7); // comma separated values
            Console.WriteLine("***************************");
            ImplicitTypes implicitTypes = new ImplicitTypes();
            implicitTypes.UnderstandImplicitTypes();
          
            Console.ReadKey();
        }
         
        public static void SimpleCallbyValue(int j)  // call by value
        {
            j = 100;
        }

        public static void SimpleCallByRef(ref int j) // call by reference
        {
            j = 100;
        }

        //out parameters are used when we expect multiple values from a function
        public static int Calculator(int a, int b, out int sum, out int product) 
        {
            sum = a + b;
            product = a * b;
            return a - b;
        }

        public static int AddElements(params int[] elements)
        {
            int sum = 0;
            foreach(int elem in elements)
            {
                sum += elem;
            }
            return sum;
        }

        public static void ParamsMethod(params int[] arr)
        {
            Console.WriteLine("There are {0} elements in the array ", arr.Length);

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}

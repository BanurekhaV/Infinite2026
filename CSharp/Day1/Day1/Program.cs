using System;


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
            Console.ReadKey();
        }

        public static void SimpleCallbyValue(int j)  // call by value
        {
            j = 100;
        }

        public static void SimpleCallByRef(ref int j)
        {
            j = 100;
        }
    }
}

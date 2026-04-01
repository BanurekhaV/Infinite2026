using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public delegate T Trans<T> (T arg);

    class Util
    {
        //delegate as an argument to a method
        public static void Transform<T>(T[] values, Trans<T> t)
        {
            for(int i=0; i<values.Length; i++)
            {
                values[i] = t(values[i]);   //t(4)
            }
        }
    }
    internal class GenericDelegates
    {
        static void Main()
        {
           // int[] arr = new int[] { 4, 5, 6 };
           float[] arr = new float[]{4.4f,5.5f,6.6f};

            Util.Transform(arr, Square);

            foreach(var n in arr)
            {
                Console.Write(n + " ");
            }
            Console.Read();
        }

        public static int Square(int x)
        {
            return x * x;
        }

        public static float Square(float x)
        {
            return x * x;
        }
    }
}

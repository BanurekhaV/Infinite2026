using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class StringEg
    {
        int mydata;  // non static member/field or instance member/field
        static int ourdata = 15; //static member/field
        float fdata;  // non static
        static void Main()
        {
           // stringOperations();
            instanceVsStatic();
            Console.Read();
        }

        public static void instanceVsStatic()
        {
            StringEg seg = new StringEg();
            seg.mydata = 100;
            seg.fdata = 125.45f;
            Console.WriteLine($"Mydata is {seg.mydata}, FloatData is {seg.fdata} and OurData is {ourdata} ");
            StringEg seg2 = new StringEg();
            Console.WriteLine($"Mydata is {seg2.mydata}, FloatData is {seg2.fdata} and OurData is {ourdata} ");
            ourdata = 25;
            seg2.mydata = 200;
            seg2.fdata = 150.57f;
            Console.WriteLine("After changing the static field value-----");
            Console.WriteLine($"Mydata is {seg.mydata}, FloatData is {seg.fdata} and OurData is {ourdata} ");
            Console.WriteLine($"Mydata is {seg2.mydata}, FloatData is {seg2.fdata} and OurData is {ourdata} ");
        }
        public static void stringOperations()
        {            
            string str;
            str = "I am a String";
            Console.WriteLine("Str for the first time is : {0}  and the value is {1} ", str.GetHashCode(), str);

            string str2 = "I am a String";
            Console.WriteLine("Str2 for the first time is : {0}  and the value is {1} ", str2.GetHashCode(), str2);

            str2 = "hello world";
            Console.WriteLine("Str2 for the first time is : {0} and the value is {1} ", str2.GetHashCode(), str2);

            string str3 = str;  //equating 2 objects will result in sharing the same reference
            Console.WriteLine("Str3 for the first time is : {0}", str3.GetHashCode());
            Console.WriteLine("--------------");
            char[] carr = new char[] { 'H', 'e', 'l', 'l', 'o' };
            string str4 = new string(carr);
            Console.WriteLine("str4 hash code " + str4.GetHashCode());

            str3 = str4;
            Console.WriteLine($"Str3 hash code is {str3.GetHashCode()} with values {str3} , str4 hash is {str4.GetHashCode()} with value {str4}");

            //string builder
            StringBuilder sb = new StringBuilder("Hello ");
            Console.WriteLine("Sb's hash code is {0} and value is {1} ", sb.GetHashCode(), sb);
            sb.Append("World");
            Console.WriteLine("Sb's hash code is {0} and value is {1} ", sb.GetHashCode(), sb);
        }
    }
}

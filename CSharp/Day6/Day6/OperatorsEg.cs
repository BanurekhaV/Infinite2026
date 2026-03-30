using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class OperatorsEg
    {
        static void Main()
        {
            //  GeneralOperators();
            //  EqualityOperators();
            StringBuilderEqualOps();


            Console.Read();
        }

        public static void EqualityOperators()
        {
            //value equality
            int x = 5, y = 5;
            Console.WriteLine(x == y);
            Console.WriteLine(x.Equals(y));

            //reference equality
            Program p1= new Program();
            Program p2 = p1;

            Console.WriteLine(p1 == p2);
            Console.WriteLine(object.Equals(p1,p2));
            Console.WriteLine(object.ReferenceEquals(p1,p2));

            Console.WriteLine("----------------------------------");
            string str1  = "Hello";
            string str2 = "Hello";

            Console.WriteLine($"str1 == str2 :{str1 == str2}");
            Console.WriteLine($"Equals :{object.Equals(str1,str2)}");
            Console.WriteLine($"Reference Equals : {Object.ReferenceEquals(str1,str2)}");

            Console.WriteLine($"str1.CompareTo(str2) : {str1.CompareTo(str2)}");
            Console.WriteLine("******************");

            const int a = 5;
            const int b = 6;
            const int c = 5;

            Console.WriteLine($"a.CompareTo(b) : {a.CompareTo(b)}");
            Console.WriteLine($"b.CompareTo(a) : {b.CompareTo(a)}");
            Console.WriteLine($"c.CompareTo(a) : {c.CompareTo(c)}");

        }

        public static void StringBuilderEqualOps()
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            Console.WriteLine(object.ReferenceEquals(sb1,sb2));
            sb1 = sb2;
            Console.WriteLine(object.ReferenceEquals(sb1,sb2));

            Console.WriteLine("==================");
            object obj1 = new StringBuilder("Hello");
            object obj2 = "Hello";
            Console.WriteLine(obj1 == obj2);
            Console.WriteLine(obj1.Equals(obj2));
        }
        public static void GeneralOperators()
        {
            //Arithmetic Operators
            int a = 36, b = 3;
            Console.WriteLine("----------Arithmetic Operators-------------");
            Console.WriteLine($"a+b ={a + b}");
            Console.WriteLine($"a-b ={a - b}");
            Console.WriteLine($"a%b = {a % b}");

            Console.WriteLine("------------Relational Operators------------");
            Console.WriteLine($"a > b = {a > b}");
            Console.WriteLine($"a == b = {a == b}");
            Console.WriteLine($"a != b = {a != b}");

            Console.WriteLine("------------Logical Operators-------------");
            bool x = true, y = false;
            Console.WriteLine($"x && y = {x && y}");
            Console.WriteLine($"x || y = {x || y}");
            Console.WriteLine($"!x = {!x}");

            Console.WriteLine("-----------Assignments Operators------------");
            int num = 5;
            num += 3; //num = num + 3
            Console.WriteLine($" +=3, num : {num}");
            num -= 3;
            Console.WriteLine($" -=3, num :{num}");
            num *= 3;
            Console.WriteLine($" *=3, num :{num}");
            num /= 3;
            Console.WriteLine($" /=3, num :{num}");
        }

    }
}

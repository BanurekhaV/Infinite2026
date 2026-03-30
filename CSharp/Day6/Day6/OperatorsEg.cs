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
            Console.WriteLine($"x || y = {x||y}");
            Console.WriteLine($"!x = {!x}");

            Console.WriteLine("-----------Assignments Operators------------");
            int num = 5;
            num += 3; //num = num + 3
            Console.WriteLine($" +=3, num : {num}");
            num -=3;
            Console.WriteLine($" -=3, num :{num}");
            num *= 3;
            Console.WriteLine($" *=3, num :{num}");
            num /=3;
            Console.WriteLine($" /=3, num :{num}");
            Console.Read();
        }

    }
}

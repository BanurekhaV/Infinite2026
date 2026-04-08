using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    internal class LambdaEg
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 28, 27, 17, 9, 34 };
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            //using lambda expressions find the square of each number
            var square = numbers.Select(x => x * x);
            Console.WriteLine("-----------Lambda-----------");
            foreach (int n in square)
            {
                Console.WriteLine(n);
            }
            Console.Read();
        }
    }
}

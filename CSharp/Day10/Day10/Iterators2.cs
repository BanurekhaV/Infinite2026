using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Iterators2
    {
        public static IEnumerable<int> GenerateRandomNumbers()
        {
            Random random = new Random();
            int year;
            while(true)
            {
                year = random.Next(1900, 2025);
                if(year % 4 ==0)
                {
                    Console.WriteLine($"{Environment.NewLine} Encountered a Leap Year : {year}");
                    yield break;
                }
                yield return year;
            }
            Console.WriteLine("Method completed successfully");
        }

        public static IEnumerable<string>GetCountries()
        {
            List<string> countries = new List<string>() { "India", "Japan", "Korea", "China", "Pakistan" };

            foreach( string country in countries )
            {                
                yield return country;
            }
        }
        static void Main()
        {
            Console.WriteLine("------------Random Number------------");
            foreach (int y in GenerateRandomNumbers())
            {
                Console.WriteLine(y);               
            }

            Console.WriteLine("---------------Countries List-------------");
          
            IEnumerable<string> enumcountries = GetCountries();
            

            foreach (var c in enumcountries)
            {
                Console.WriteLine(c);
            }
            Console.Read();
        }
    }
}

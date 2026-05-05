using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aggregates_General();
            //Seed_Aggregations();
            //Element_At();
            //First_Operators();
            Single_Ops();
            Console.Read();
        }

        static void Aggregates_General()
        {
            int[] numbers = { 2, 34, 5, 6, 7, 8, 9 };
            var sum = numbers.Sum();
            var max = numbers.Max();
            var min = numbers.Min();
            var avg = numbers.Average();
            Console.WriteLine($"Sum :{sum}, Max :{max}, Min : {min} and Average : {avg}");
        }

        //aggregates with seed

        static void Seed_Aggregations()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var result = numbers.Aggregate(10,(a,b) => a + b);   // 25
            Console.WriteLine("Aggregates Sum with seed : {0}", result);

            result = numbers.Aggregate((a,b)=> a * b);
            Console.WriteLine("Just Aggregated product : {0}", result);
        }

        //Element Operators
        static void Element_At()
        {
            string[] fruits = { "Apples", "Oranges", "Kiwi", "Papaya", "Banana" };

            var result = fruits.ElementAt(3);  // papaya
            Console.WriteLine(result);

            //result = fruits.ElementAt(5);  // throws an exception

            //to avoid exceptions

            result = fruits.ElementAtOrDefault(5);
            Console.WriteLine(result);
        }

        //positional operators
        static void First_Operators()
        {
            string[] colors = { "Red", "Blue", "Green", "White", "Black", "Yellow" };

            Console.WriteLine(colors.First());
            Console.WriteLine(colors.Last());

            string[] colors1 = { };
            Console.WriteLine(colors1.FirstOrDefault());
            Console.WriteLine(colors1.LastOrDefault());
        }

        //single operators
        static void Single_Ops()
        {
            string[] names = { "Narendra Modi" };
            string[] names2 = { "Donald Trump", "Nitanhu", "Obama" };
            string[] empty = { };

            Console.WriteLine(names.Single());

            //Console.WriteLine(names2.Single());  // throws exception
            // Console.WriteLine(names2.SingleOrDefault()); // throws exception
            // Console.WriteLine(empty.Single());   // throws exception
            Console.WriteLine(empty.SingleOrDefault());  // does not throw exception
        }
    }
}
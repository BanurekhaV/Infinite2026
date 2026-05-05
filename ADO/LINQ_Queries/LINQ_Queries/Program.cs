using System;
using System.CodeDom.Compiler;
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
            //Single_Ops();
            //  Sorting_func();
            // InnerJoins();
            //Group_By_Func();
            //Group_Join();
            // Skip_Func();
            // Skip_While_fn();
            Take_Func();
            TakeWhile_Func();
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
            var result = numbers.Aggregate(10, (a, b) => a + b);   // 25
            Console.WriteLine("Aggregates Sum with seed : {0}", result);

            result = numbers.Aggregate((a, b) => a * b);
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

        static void Sorting_func()
        {
            string[] names2 = { "Narendra Modi", "Donald Trump", "Nitanhu", "Obama" };

            //sort asc
            var namesort = names2.OrderBy(x => x);

            foreach (var nm in namesort)
            {
                Console.WriteLine(nm);
            }
            Console.WriteLine("-----------descending sort----------");

            namesort = names2.OrderByDescending(x => x);

            foreach (var nm in namesort)
            {
                Console.WriteLine(nm);
            }

            //multiple sorts
            string[] citys = { "Nagpur", "Delhi", "Mumbai", "Ambal", "abcde", "Hyderabad", "Bangalore", "Chennai", "Vishakapatnam" };

            var mulsort = citys.OrderBy(c => c.Length).ThenBy(c => c);

            Console.WriteLine("------Ascending multiple Sort--------");
            foreach (string s in mulsort)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------Descending multiple Sort--------");
            mulsort = citys.OrderByDescending(c => c.Length).ThenByDescending(c => c);

            foreach (string s in mulsort)
            {
                Console.WriteLine(s);
            }
        }

        static void InnerJoins()
        {
            string[] str1 = { "India", "Japan", "US", "Korea", "Russia" };
            string[] str2 = { "China", "Pakistan", "India", "Korea", "Japan", "UK" };

            var result = str1.Join(str2, s1 => s1, s2 => s2, (s1, s2) => s1);

            Console.WriteLine("--------Post Inner Join----------");
            foreach (var country in result)
            {
                Console.WriteLine(country);
            }
        }

        //Group by

        static void Group_By_Func()
        {
            int[] numbers = { 10, 15, 20, 25, 30, 35, 42 };

            var result = numbers.GroupBy(num => (num % 10 == 0)); //query construction

            foreach (IGrouping<bool, int> gp in result)  //query execution
            {
                if (gp.Key == true)
                {
                    Console.WriteLine(" Group 1 --- Numbers Divisible by 10 ");
                }
                else
                {
                    Console.WriteLine(" Group 2 --- Numbers not Divisible by 10 ");
                }

                foreach (int n in gp)
                {
                    Console.WriteLine(n);
                }
            }
        }

        //group_join -- works like a left outer join
        static void Group_Join()
        {
            Language[] languages = new Language[]
            {
                new Language{Id = 1, Name = "English"},
                new Language{Id = 2, Name = "German"},
                new Language{Id = 3, Name = "Spanish"},
            };

            Person[] persons = new Person[]
            {
               new Person{LanguageId = 1 , PersonName ="Satheesh"},
               new Person{LanguageId = 1 , PersonName ="Naresh"},
               new Person{LanguageId = 2 , PersonName ="Girish"},
               new Person{LanguageId = 2 , PersonName ="Sumesh"},
               new Person{LanguageId = 1 , PersonName ="Ramesh"},
            };

            var result = languages.GroupJoin(persons, l => l.Id, p => p.LanguageId,
                (lang, ps) => new { Key = lang.Name, Person = ps });

            foreach (var language in result)
            {
                Console.WriteLine(String.Format("Persons speaking {0} : ", language.Key));

                foreach (var person in language.Person)
                {
                    Console.WriteLine(person.PersonName);
                }
            }
        }

        //skip
        static void Skip_Func()
        {
            string[] words = { "one", "two", "three", "four", "five", "six" };

            var result = words.Skip(3);
            Console.WriteLine("--------Skips elements ------");
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static void Skip_While_fn()
        {
            string[] words = { "one", "six", "two", "three", "four", "five", "Seven", "ten" };

            var result = words.SkipWhile(w => w.Length == 3);

            Console.WriteLine("Skip While ------------");
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static void Take_Func()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = numbers.Take(5);
            Console.WriteLine("Takes first 5 elements------------");

            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
        }
        static void TakeWhile_Func()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.TakeWhile(n => n < 5);

            Console.WriteLine("Take While Condition---------");

            foreach(int n in result)
            {
                Console.WriteLine(n);
            }
        }
    }
    class Language
    {
        public int Id {  get; set; }
        public string Name { get; set; }
    }

    class Person
    {
        public int LanguageId { get; set; }
        public string PersonName { get; set; }
    }
}
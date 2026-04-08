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

            //2. using lamda find all numbers that are divisible by 3 and display
             List<int>divby3 = numbers.FindAll(x => (x % 3)==0);

            foreach(var num in divby3)
            {
                Console.WriteLine("Numbers Divisible by 3 are : " + num);
            }

            //query syntax
            string[] names = { "Bob", "Smith", "Steve", "James","Mark" };

            // set of names that have 'a' in them
            var namequery = from n in names
                            where n.Contains('a')
                            select n;

            foreach(var name in namequery)
            {
                Console.Write("Name :" + name);
            }

            //method syntax
            List<Student> studlist = new List<Student>()
            {
                new Student(){Id =1,Name="Jagadeesh",Age=13},
                new Student(){Id =2,Name="Monika",Age=21},
                new Student(){Id =3,Name="Brijesh",Age=18},
                new Student(){Id =4,Name="Roma",Age=15},
                new Student(){Id =5,Name="Nakul",Age=20},
            };

            //find out all teenage students
            var teenagers = studlist.Where(s => s.Age > 12 && s.Age < 20);
            foreach (var student in teenagers)
            {
                Console.WriteLine(student.Name);
            }

            //to sort the students by their names
            var sortednames = studlist.OrderBy(s => s.Name);

            
            foreach (var item in sortednames)
            {
                Console.WriteLine(item.Name);
            }

            IEnumerable<string> stdname = from s in studlist
                                          where s.Name.EndsWith("h")
                                          select s.Name;
            foreach (var name in stdname)
            { 
                Console.WriteLine(name);
            }

            IEnumerable<Student> stdnames = from s in studlist
                                          where s.Name.EndsWith("h")
                                          select s;

            foreach (var student in stdnames)
            {
            Console.WriteLine(student.Name + " "+ student.Id +" "+ student.Age); 
            }

            Console.WriteLine("-------Deferred Vs Immediate -------");

            //query declaration /construction

            var teenstuds = studlist.Where(s => s.Age > 12 && s.Age < 20)
                .Select(p => p.Name);

            var teenstudsimmediate = studlist.Where(s => s.Age > 12 && s.Age < 20)
                .Select(p => p.Name).ToList();

            //adding one more student after query construction
            studlist.Add(new Student { Id = 10, Name = "Jyothi", Age = 14 });

            //query execution

            Console.WriteLine("------immediate-------");
            foreach (var ti in teenstudsimmediate)
            {
                Console.WriteLine(ti);
            }
            Console.WriteLine("------deferred--------");
            foreach (var student in teenstuds)
            {
                Console.WriteLine(student);
            }
            Console.Read();
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

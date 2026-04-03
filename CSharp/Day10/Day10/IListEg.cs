using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{

    internal class IListEg
    {
        public static void Show(IList<string> lst)
        {
            foreach (string str in lst)
            {
                Console.WriteLine("\t" + str);
            }
        }
    }

    class Student : IEquatable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stream { get; set; }
        public float GPA { get; set; }

        public bool Equals(Student s)
        {
            return (this.Id == s.Id);
        }
        class TestIList
        {
            public static IEnumerable<string> IteratorEg()
            {
                List<string> colors = new List<string>()
                {
                    "Red", "Blue","Green","Yellow", "Orange"                    
                };

                foreach(var items in colors)
                {
                    yield return items;
                }
            }
            static void Main()
            {
                string[] courses = { "CSharp", "Sql", "ADO", "ASP" };

                List<string> list = new List<string>();
                list.Add("30 hrs");
                list.Add("20 hrs");
                list.Add("10 hrs");
                list.Add("30 hrs");

                Console.WriteLine("Course Names: ");
                IListEg.Show(courses);

                Console.WriteLine("Duration of Courses :");
                IListEg.Show(list);

                Console.WriteLine("----------Equatable Interface--------");
                var stud1 = new Student() { Id = 1,Name="Rama",Stream="ECE",GPA=5.5f};
                var stud2 = new Student() { Id = 2, Name = "Krishna", Stream = "CSE", GPA = 7.5f };
                var stud3 = new Student() { Id = 1, Name = "RamaKrishna", Stream = "ECE", GPA = 8.5f };

                Console.WriteLine(stud1.Equals(stud2));
                Console.WriteLine(stud1.Equals(stud3));

                Console.WriteLine("----------Iterator Yield Example---------");
                IEnumerable<string> ResultData = IteratorEg();

                foreach(var i in ResultData)
                {
                    Console.WriteLine(i);
                }
                Console.Read();
            }
        }
    }
}

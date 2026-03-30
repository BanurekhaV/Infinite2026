using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Student : IComparable
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public void CompareStudentsName()
        {
            Student[] studarray = new Student[]
            {
                new Student(){Name= "Rithika", Marks= 80},
                 new Student(){Name= "Rekashini", Marks= 82},
                  new Student(){Name= "Kaviranjani", Marks= 68},
            };
            Array.Sort(studarray);
            foreach(var s in studarray)
            {
                Console.WriteLine(s.Name);
            }
        }

        public int CompareTo(object obj)
        {
            Student stdobj = obj as Student; //(typecasting object type to student type)
            if(stdobj !=null)
            {
                return this.Name.CompareTo(stdobj.Name);
            }
            return -1;
        }
    }
    internal class ComparissionEg
    {
        static void Main()
        {
            string[] fruits = { "Orange", "Banana", "Apple", "Guava" };
            Array.Sort(fruits);

            foreach(string f in fruits)
            {
                Console.WriteLine(f);
            }

            Student stud = new Student();
            stud.CompareStudentsName();

            Console.WriteLine("------------Comparing Marks-------------");

            Marks m = new Marks();


           // Student s = new Student() ;
            Student s1 = new Student
            {
                Name = "Deepika",
                Marks = 80
            };
            Student s2 = new Student()
            {
                Name = "Adithya",
                Marks = 80
            };

            int result = m.Compare(s1,s2);
            if (result == 0)
                Console.WriteLine("Both marks are equal");
            else if (result == 1)
                Console.WriteLine("S1's marks is higher");
            else Console.WriteLine("S2's marks is higher");

            //types of class
            //1. sealed 
            FinalClass fc = new FinalClass();
            fc.sealedFunc1();
            Console.Read();
        }
    }
    // types of classes
    //2. partial example
    partial class Marks : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Marks.CompareTo(y.Marks);
        }
    }

    sealed class FinalClass
    {
        public void sealedFunc1()
        {
            Console.WriteLine("Hi sealed...");
        }
    }
}

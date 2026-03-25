using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    struct Student
    {
       public int Id;
       public float MathsMarks;
       public float ScienceMarks;
       public string SName;

        public void ShowStudent()
        {
            Console.WriteLine($"Id : {Id}, Name :{SName}, Maths :{MathsMarks}, Science :{ScienceMarks}");
        }
    }
    internal class UserDefinedValueTypes
    {
        public static void Main()
        {
            Student s1 = new Student();
            s1.Id = 1;
            s1.SName = "Hariharasudhan";
            s1.MathsMarks = 86;
            s1.ScienceMarks = 90;
            s1.ShowStudent();

            Student s2 = s1;  //equated 2 structures and hence values are copied
            Console.WriteLine("--------------------------------");
            s2.ShowStudent();

            s1.SName = "Sivaraj";
            Console.WriteLine("----------------- After changes-------------------");
            s1.ShowStudent();
            s2.ShowStudent();
            Console.Read();
        }
    }
}

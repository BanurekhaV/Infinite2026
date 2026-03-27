using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Student
    {
        private string code = "N.A";
        private string Name = "Unknown";
        private int age = 30;

        //declaring properties for the above field
        public string StdCode
        {
            get { return code; }
            set { code = value; }
        }

        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int Age
        {
            get { return age; }
        }

        //let us override toString() of the Object class to define the funvtion the way we want to display
        public override string ToString()
        {
            return "Code = " + code + " , Student Name = "+ Name + " and Age  = "+ age;
        }
    }
    internal class PropertiesEg
    {
        static void Main()
        {
            Student s = new Student();
            s.StdCode = "1001";
            s._Name = "Babitha";

            Console.WriteLine($"Student Info : Name = {s._Name}, Code ={s.StdCode} and age is {s.Age}");
            Console.WriteLine("----------------------");

            s.StdCode = "S005";
            Console.WriteLine("Student Info : " + s.ToString());

            Console.Read();
        }
    }
}

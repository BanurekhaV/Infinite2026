using System;
using System.Runtime.InteropServices;


namespace Day4
{
    class Student
    {
        private string RollNo;
        private string Name;
        private string Class;

        public void GetData()
        {
            Console.WriteLine("Enter Roll No :");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class :");
            Class = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Name of the Student = " + Name);
            Console.WriteLine("Roll No of the Student = " + RollNo);
            Console.WriteLine("Class of the Student = " + Class);
        }
    }

    class Marks : Student
    {
        protected int[] marks = new int[5];

        public void GetMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter Subject {0} Marks : ", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("marks in Subject {0} {1} : ", i + 1, marks[i]);
            }
        }

        class Result : Marks
        {
            int Totalmarks = 0;

            public void GetResult()
            {
                for (int i = 0; i < marks.Length; i++)
                {
                    Totalmarks += marks[i];
                }
            }

            public void DisplayResult()
            {
               Console.WriteLine("========  Results ========");
               PutData();
               PutMarks();
               Console.WriteLine("Total marks Secured = " + Totalmarks);
            }
        }
        internal class InheritanceEg
        {
            static void Main()
            {
                Result result = new Result();
                result.GetData();
                result.GetMarks();
                result.GetResult();
                result.DisplayResult();
                Console.Read();
            }
        }
    }
}

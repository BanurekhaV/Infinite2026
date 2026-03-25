using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Employee
    {
        int Empid;     //4
        string EmpName; //10
        float Empsalary;    //8

        public Employee()  // 1. Empty constructor
        {
            Empid = 1;
            EmpName = "Arun";
            Empsalary = 43000;
        }

        internal Employee(int e, string s)  // 2. Parameterized constructor
        {
            Empid = e;
            EmpName = s;
        }
        public void ShowEmp()      // 4
        {
            Console.WriteLine($"Empid :{Empid}, Name : {EmpName} and Salary :{Empsalary}");
        }

        ~Employee()
        {
            Console.WriteLine("bye from Employee");
            Console.Read();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.ShowEmp();
            Employee emp2 = new Employee(2,"Kaniga");
            emp = null;
            GC.Collect();
            emp2.ShowEmp();
            Console.Read();
        }
    }
}

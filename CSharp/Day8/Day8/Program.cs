using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Program
    {
        public static void ListOps1()
        {
            List<int> list1 = new List<int>();
            list1.Add(12);
            list1.Add(1);
            list1.Add(15);
            list1.Add(2);

            list1.Sort();

            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }
        }

        public static void ListOps2()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(101, "Gopika", 12000, "Infinite"));
            emplist.Add(new Employee(103, "Kaniga", 11000, "Infinite"));
            emplist.Add(new Employee(102, "Priya", 13000, "Infinite"));
            emplist.Add(new Employee(104, "Subhashini", 10000, "Infinite"));

            foreach (Employee employee in emplist)
            {
                Console.WriteLine(employee.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("----------After Sorting Employees on salary---------");
            Console.WriteLine();
            emplist.Sort();
            foreach (Employee employee in emplist)
            {
                Console.WriteLine(employee.ToString());
            }
        }
        static void Main(string[] args)
        {
            ListOps1(); 
            Console.WriteLine("----------------------");
            ListOps2();  // working with user defined object collection
            Console.Read();
        }
    }

    //comparing user defined objects in a list using CompareTo of IComparable 
    class Employee : IComparable
    {
        int Empid;
        string EmpName;
        float EmpSalary;
        string CompanyName;

        public Employee(int empid, string empName, float empSalary, string companyName)
        {
            Empid = empid;
            EmpName = empName;
            EmpSalary = empSalary;
            CompanyName = companyName;
        }

        public int CompareTo(object obj)
        {
            Employee other = obj as Employee;

            if(this.EmpSalary == other.EmpSalary)
            {
                return this.Empid.CompareTo(other.Empid);
            }
           // return other.EmpSalary.CompareTo(this.EmpSalary); // descending sort
           return this.EmpSalary.CompareTo(other.EmpSalary);  //ascending sort
        }

        public override string ToString()
        {
            return string.Format("Employee Id : " + Empid + " named : " + EmpName +  " works with : " + CompanyName +
                " and earns a salary of  :" + EmpSalary);
        }
    }
}

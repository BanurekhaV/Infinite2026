using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    internal class Program
    {
        //injector class
        static void Main(string[] args)
        {
            //thru constructor
            // EmployeeBAL ebal = new EmployeeBAL(new EmployeeDAL());


            //injecting the dependency using the public property

           // EmployeeBAL ebal = new EmployeeBAL();
            // ebal.empDataLayer = new EmployeeDAL();

            // Via Method Injection
            EmployeeBAL ebal = new EmployeeBAL();
            List<Employee> elist = ebal.GetAllEmployees(new EmployeeDAL());
            foreach (Employee employee in elist)
            {
                Console.WriteLine($"ID = {employee.Id} Name = {employee.Name}, and Department = {employee.DeptName}");
            }
            Console.Read();
        }
    }
}

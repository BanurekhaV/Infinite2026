using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
            //dependency class
   public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> employeelist = new List<Employee>
            { 
                new Employee{Id = 1, Name = "Kajal", DeptName= "IT" },
                new Employee{Id = 2, Name = "Ramesh", DeptName= "Payroll" },
                new Employee{Id = 3, Name = "Kamini", DeptName= "HR" },
            };
            return employeelist;
        }
    }
}

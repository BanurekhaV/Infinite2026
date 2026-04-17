using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPrj_NUnit
{
    public class Employee
    {
        public int ? Id { get; set; }
        public string Name { get; set; }
        public double ? Salary { get; set; }

        public List<Employee> Employeelist()
        {
            List<Employee> employeelist = new List<Employee>()
            {
                new Employee{Id =101, Name = "Manjula", Salary= 5000},
                 new Employee{Id =102, Name = "Deepa", Salary= 6000},
                  new Employee{Id =103, Name = "Roja", Salary= 4500},
            };
            return employeelist;
        }

        public int AddtwoNos(int x, int y)
        {
            return x + y; 
        }

        public string Login(string userid, string password)
        {
            if (string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(password))
            {
                return "User Id or Password Cannot be Empty";
            }
            else if (userid == "Admin" && password == "Admin@123")
            {
                return "Welcome Admin";
            }
            else
                return "Incorrect UserId or Password";
        }
    }
    
}

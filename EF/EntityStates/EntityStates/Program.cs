using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityStates
{
    internal class Program
    {
        static InfiniteDBEntities db = new InfiniteDBEntities();
        static tblEmployee employee = new tblEmployee();  //detached

        static void Main(string[] args)
        {
            Console.WriteLine("---------- Entity States -----------");
            Console.WriteLine($"State of the newly Created Employee Object is :{db.Entry(employee).State}");
            Console.WriteLine();

            //inserting an employee
            employee.EmpId = 150;
            employee.EmpName = "Dummy";
            employee.Gender = "Others";
            employee.Salary = 6200;
            employee.DepartmentId = 5;

            // Console.WriteLine("---------------Insertion-------------------");
            //AddEmployee(employee);
            // Console.WriteLine("--------------- Updation -------------------");
            // UpdateEmp();
            //Console.WriteLine("------------------ Deletion --------------------");
            //DeleteEmp();
            Console.WriteLine("-------------- All Employees ----------------");
            ShowEmp();
            //Console.WriteLine("--------------- Stored Procedure------------------");
            //CallProcedure();
            Console.WriteLine("--------------- Function call ---------------------");
            CallFunction();
            Console.Read();
        }

        static void AddEmployee(tblEmployee emp)
        {
            Console.WriteLine($"Before Insertion, the state of Employee Entity is : {db.Entry(emp).State}");
            db.tblEmployees.Add(emp);  // changes are made only to the dbset
            Console.WriteLine($"After adding and before saving, the state of Employee Entity is : {db.Entry(emp).State}");
            db.SaveChanges(); // changes will be made to the database
            Console.WriteLine($"After saving, the state of Employee Entity is : {db.Entry(emp).State}");
        }

        static void ShowEmp()
        {
            var emplist = db.tblEmployees.ToList();

            foreach(var emp in emplist)
            {
                Console.WriteLine($" {emp.EmpId}  {emp.EmpName} {emp.Salary}  {emp.DepartmentId}");
            }
        }

        static void UpdateEmp()
        {
            Console.WriteLine("Enter Employee Id to Update");
            int eid = Convert.ToInt32( Console.ReadLine());   
            employee = db.tblEmployees.Find(eid);

            if(employee != null )
            {
                Console.WriteLine($"Before Update , the state of Employee entity is : {db.Entry(employee).State}");
                employee.EmpName = "Haritha";
                Console.WriteLine($"After Update and before Save, the state of Employee entity is : {db.Entry(employee).State}");
                db.SaveChanges();
                Console.WriteLine($" After Saving the Update, the state of Employee entity is : {db.Entry(employee).State}");
            }
            else
                Console.WriteLine("No matching emloyee record found");
        }

        static void DeleteEmp()
        {
            Console.WriteLine("Enter Employee Id to Delete");
            int eid = Convert.ToInt32(Console.ReadLine());
            employee = db.tblEmployees.Find(eid);
            if (employee != null)
            {
                Console.WriteLine($"Before Deletion, the state of Employee entity is : {db.Entry(employee).State}");
                db.tblEmployees.Remove(employee);
                Console.WriteLine($" After Delete, before Save, the state of Employee entity is : {db.Entry(employee).State}");
                db.SaveChanges();
                Console.WriteLine($" After Saving the delete, the state of Employee entity is : {db.Entry(employee).State}");
            }
            else
                Console.WriteLine("No employee with the ID found");
        }

        static void CallProcedure()
        {

        }

        static void CallFunction()
        {
            var results = db.fn_GetEmpByGender("Female");

            foreach(var item in  results)
            {
                Console.WriteLine($"{item.EmpNumber}  {item.EmployeeName} {item.Gender}");
            }
        }
    }
}

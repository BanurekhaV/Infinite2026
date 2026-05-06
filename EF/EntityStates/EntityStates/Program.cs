using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
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
            //Console.WriteLine("-------------- All Employees ----------------");
            //ShowEmp();
            Console.WriteLine("--------------- Stored Procedure------------------");
            CallProcedure();
            //Console.WriteLine("--------------- Function call ---------------------");
            //CallFunction();
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
            ObjectParameter param = new ObjectParameter("eSal",typeof(decimal));
            ObjectParameter param2 = new ObjectParameter("Empname", typeof(string));
            param2.Value = "Banurekha";
            db.sp_getEmpSalary(param2.Value.ToString(), param);
            Console.WriteLine((param.Value).ToString());


            Console.WriteLine("----------- Employee Total Sal and Count for a Department-------");

            //option 1
            Console.WriteLine("Enter Dept id for the procedure :");
            int depid = Convert.ToInt32(Console.ReadLine());

            using (var context = new InfiniteDBEntities())
            {
                var ReturnValue = new SqlParameter
                {
                    ParameterName = "@ReturnVal",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Direction = System.Data.ParameterDirection.Output,
                };

                var TotSalary = new SqlParameter
                {
                    ParameterName = "@totsal",
                    SqlDbType = System.Data.SqlDbType.Decimal,
                    Direction = System.Data.ParameterDirection.Output
                };

                var Deptid = new SqlParameter
                {
                    ParameterName = "@deptid",
                    Value = depid,
                    SqlDbType = System.Data.SqlDbType.Int,
                };
                //calling the proc sp_getempcount

                 db.Database.ExecuteSqlCommand(
                  "Exec @ReturnVal = sp_getEmpCount @deptid,@totsal OUTPUT",
                  ReturnValue,Deptid,TotSalary);


                int TotEmp = (int)ReturnValue.Value;
                decimal Deptsalary = (decimal)TotSalary.Value;

                Console.WriteLine($"No of Employees in Dept  : {Deptid.Value} is  {TotEmp} and the Total Salary for the Dept : {Deptsalary}");
            }

            //option 2
            Console.WriteLine("---------- Linq based procedure output--------");
            var results = from e in db.tblEmployees
                          group e by e.DepartmentId into deptgp
                          select new
                          {
                              Deptid = deptgp.Key,
                              Empcount = deptgp.Count(),
                              TotSal = deptgp.Sum(emp => emp.Salary)
                          };

            foreach (var e in results)
            {
                Console.WriteLine($"Department Id : {e.Deptid} has  {e.Empcount} no. of Employees and the Department Total salary is :{e.TotSal}");
            }

            //option 3

            Console.WriteLine("------------------------Using ADO classes--------------");
            using (var context = new InfiniteDBEntities())
            {
                //ensure the connection is open
                var connection = context.Database.Connection;
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "dbo.sp_getEmpCount";
                    command.CommandType = CommandType.StoredProcedure;

                    //input parameter
                    Console.WriteLine("Enter The dept Id : ");
                    int did = Convert.ToInt32(Console.ReadLine());

                    var DeptIdParam = new SqlParameter("@deptid", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = did
                    };

                    //output parameter

                    var DeptTotSalParam = new SqlParameter
                    {
                        ParameterName = "@totsal",
                        SqlDbType = SqlDbType.Decimal,
                        Direction = ParameterDirection.Output,
                    };

                    //return value parameter
                    var EmpCountParam = new SqlParameter
                    {
                        ParameterName = "@ReturnValue",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.ReturnValue,
                    };

                    command.Parameters.Add(DeptIdParam);
                    command.Parameters.Add(EmpCountParam);
                    command.Parameters.Add(DeptTotSalParam);

                    command.ExecuteNonQuery();

                    //let us het the values from the procedure

                    decimal totempsal = Convert.ToDecimal(DeptTotSalParam.Value);
                    int empcount = (int)EmpCountParam.Value;

                    Console.WriteLine($" Dept Total Salary : {totempsal},and No.Of Employees:{empcount}");
                }
            }
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

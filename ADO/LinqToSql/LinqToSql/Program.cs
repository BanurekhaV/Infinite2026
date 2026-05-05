using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    internal class Program
    {
        static vsDataContext db = new vsDataContext();
        static void Main(string[] args)
        {
            var emp = db.Emps.ToList();

            foreach(var e in emp)
            {
                Console.WriteLine($"{e.empno} {e.ename} {e.job} {e.sal}");
            }

            Console.WriteLine("-------------- Procedure Call-------------");

            decimal? Salary = 0;
            string ename = "Banurekha";

            db.sp_getEmpSalary(ename, ref Salary);
            Console.WriteLine($" {ename} earns a Salary of {Salary} Rupees..");
            Console.Read();
        }
    }
}

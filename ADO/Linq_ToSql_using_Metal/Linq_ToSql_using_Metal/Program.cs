using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Linq_ToSql_using_Metal
{
    internal class Program
    {
        static string str = ConfigurationManager.ConnectionStrings["nwconnectstr"].ConnectionString;

        static NWindContext db = new NWindContext(str);
        static void Main(string[] args)
        {
            var custdetails = from c in db.Customers
                              orderby c.ContactName
                              select c;

            foreach(var c in custdetails)
            {
                Console.WriteLine($"{c.CustomerID} {c.ContactName} {c.CompanyName} {c.Country}");
            }

            var emp = db.Employees.ToList();
            Console.WriteLine( "---------------------------------");
            foreach (var e in emp)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} { e.HireDate}");
            }

            Console.WriteLine("-------------------------------------");

            var expprd = db.
            Console.Read();
        }
    }
}

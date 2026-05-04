using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace ConnectionPooling
{
    internal class Program
    {
        public static string connectstr = "Data Source = Laptop-tjj7d977; Initial Catalog = Northwind;" +
            "Trusted_connection = true; Pooling = true;";
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for(int i=0; i<1000; i++)
            {
                SqlConnection con = new SqlConnection(connectstr);
                con.Open();
                con.Close();
            }
            stopwatch.Stop();
            Console.WriteLine($"The Time taken : {stopwatch.ElapsedMilliseconds} ms");
            Console.Read();
        }
    }
}

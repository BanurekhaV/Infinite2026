using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries
{
    internal class Linq_with_Datatables
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id",typeof(int));
            dt.Columns.Add("Product",typeof(string));

            dt.Rows.Add(1, "Swiss Chocolate");
            dt.Rows.Add(2, "Gucci Bags");
            dt.Rows.Add(3, "Sketchers shoe");
            dt.Rows.Add(4, "USB's");
            return dt;
        }

        static void Main()
        {
           // Linq_Dt1();
            Linq_Dt2();
            Console.Read();
        }

        static void Linq_Dt1()
        {
            DataTable dtforreturn = GetData();

            //method syntax

            var result = dtforreturn.AsEnumerable().Where(x => x.Field<int>("Id") == 4).FirstOrDefault();

            if (result != null)
            {
                Console.WriteLine(result["Id"] + " " + result["Product"]);
            }
            else
                Console.WriteLine("No Product found with the given ID");

            Console.WriteLine("***********************************");

            //query syntax

            var dtrows = (from prod in dtforreturn.AsEnumerable()
                          where prod.Field<int>("Id") == 4
                          select prod).FirstOrDefault();

            if (dtrows != null)
            {
                Console.WriteLine(dtrows["Id"] + " " + dtrows["Product"]);
            }
            else
                Console.WriteLine("No Product found with the given ID");

            //converting the enumerable collection back to datatable
            Console.WriteLine("---------------------------");

            var dt = dtforreturn.AsEnumerable().Where(f => f.Field<int>("Id") > 1);

            DataTable tableagain = dt.CopyToDataTable();

            foreach (DataRow row in tableagain.Rows)
            {
                foreach (DataColumn dc in tableagain.Columns)
                {
                    Console.Write(row[dc] + " ");
                }
                Console.WriteLine();
            }
        }

        //method to return dataset by retrieving records from db

        static DataSet GetDataSet()
        {
            SqlConnection con = new SqlConnection("Data Source = Laptop-tjj7d977;  Database=infinitedb;" +
                "Integrated security = true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from emp", con);
            DataSet ds = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "Emp");
            return ds;
        }
        static void Linq_Dt2()
        {
            //let us obtain the data source to query upon
            var empdatasource = GetDataSet().Tables["Emp"].AsEnumerable();

            //query 1 - to get employees having salary > 2000
            var query = from e in empdatasource
                        where e.Field<int>("Sal") > 2000
                        orderby e.Field<int>("Sal")
                        select e;

            foreach (var row in query)
            {
                string str = $"EmpNo : {row["Empno"]}, Name : {row["Ename"]}, Salary : {row["Sal"]}";
                Console.WriteLine(str);
            }

            //query 2 - employees who have joined in the year 1987
           
            //loading the query result onto a datatable

            DataTable dt1 = query.CopyToDataTable();
        }

        
    }
}

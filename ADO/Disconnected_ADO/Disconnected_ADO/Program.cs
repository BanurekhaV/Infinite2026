using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disconnected_ADO
{
    internal class Program
    {
        public static SqlConnection con = null;
        public static SqlDataAdapter adapter = null;
        public static DataSet ds = null;

        static void Main(string[] args)
        {
            // AddShipper();
            Update_Region();
           // DisconnectedDataRead();

            Console.Read();
        }

        static void DisconnectedDataRead()
        {
            con = new SqlConnection("Data Source = laptop-tjj7d977; initial catalog = Northwind; integrated security =true;");
           con.Open();

            adapter = new SqlDataAdapter("select * from Region",con);

            ds = new DataSet();

            adapter.Fill(ds,"NRegion");

            DataTable dataTable = ds.Tables["NRegion"];  // dataTable object points to the specified table contents of the DataSet

            //to access the data from the dataset via the datatable we will iterate

            foreach(DataRow row in dataTable.Rows )
            {
                foreach(DataColumn dc in dataTable.Columns )
                {
                    Console.Write(row[dc] + " ");
                }
                Console.WriteLine();
            }
            //adding one more datatable to the dataset
            Console.WriteLine("=============================");
            adapter = new SqlDataAdapter("select * from Shippers", con);
            adapter.Fill(ds, "NShippers");
            dataTable = ds.Tables["NShippers"];

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn dc in dataTable.Columns)
                {
                    Console.Write(row[dc] + " ");
                }
                Console.WriteLine();
            }

            //procedure call
            Console.WriteLine("******** Procedure Call **********");
            Console.WriteLine("-----------------------");
            adapter = new SqlDataAdapter("[ten most expensive products]", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(ds, "ExpProducts");

            dataTable = ds.Tables["ExpProducts"];

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn dc in dataTable.Columns)
                {
                    Console.Write(row[dc] + " ");
                }
                Console.WriteLine();
            }
        }

        //let us try to add one row of data to a Table
        public static void AddShipper()
        {
            con = new SqlConnection("Server = laptop-tjj7d977; Database = Northwind; Integrated security=true;");
            con.Open();

            adapter = new SqlDataAdapter("select * from Shippers", con);
            ds = new DataSet();
            adapter.Fill(ds, "NShippers");
            DataTable dt = ds.Tables["NShippers"];

            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    Console.Write(dr[dc] + " ");
                }
                Console.WriteLine();                
            }
            //now add one row to the shipper table
            DataRow row = ds.Tables["NShippers"].NewRow();

            //now let us give values to the columns of the new row
            row["Companyname"] = "Fedex";
            row["phone"] = "(110) - 234567";

            //now the new row with data has to be added to the rows collection of the datatable
            ds.Tables["NShippers"].Rows.Add(row);

            //now this new row needs to be inserted in the physical table
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();

            int res = adapter.Update(ds, "NShippers"); // this statement actually updates the table
            Console.WriteLine("*************** New Row Updation ************");
            Console.WriteLine(res + " No of Rows Affected...");

            adapter.Fill(ds, "Nshippers");

            dt = ds.Tables["NShippers"];

            foreach(DataRow dr in dt.Rows)
            {
                foreach(DataColumn dc in dt.Columns)
                {
                    Console.Write(dr[dc] + " ");
                }
                Console.WriteLine();
            }

        }

        //update a record
        public static void Update_Region()
        {
            try
            {
                con = new SqlConnection("Server = laptop-tjj7d977; Database = Northwind; Integrated security=true;");
                con.Open();
                string query = "Select * from Region";
                adapter = new SqlDataAdapter(query, con);
                ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        Console.Write(dr[dc] + " ");
                    }
                    Console.WriteLine();
                }

                //update a row
                dt = ds.Tables[0];
                dt.Rows[5]["RegionDescription"] = "Non Cyclonic Region";
                SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = scb.GetUpdateCommand();
                adapter.Update(ds);
                Console.WriteLine();
               // adapter.Fill(ds);
                Console.WriteLine("-------Post Updation--------");
               

                foreach (DataRow dr1 in dt.Rows)
                {
                    foreach (DataColumn dc1 in dt.Columns)
                    {
                        Console.Write(dr1[dc1] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

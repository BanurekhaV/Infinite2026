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
            DisconnectedDataRead();
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
        }
    }
}

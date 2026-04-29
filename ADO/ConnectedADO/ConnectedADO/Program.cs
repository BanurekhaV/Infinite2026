using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedADO
{
    internal class Program
    {
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader dataReader = null;
        static void Main(string[] args)
        {
            SelectData();
            Console.Read();
        }

        public static void SelectData()
        {
            try
            {
                conn = getConnection();
                cmd = new SqlCommand("select * from tblemployee");
                cmd.Connection = conn;
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader[0] + " " + dataReader[1] + " " + dataReader[2] + " "
                        + dataReader[3] + " " + dataReader[4]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        //common function to get the connection of the database

        static SqlConnection getConnection()
        {
            conn = new SqlConnection("Data Source = LAPTOP-TJJ7D977;Initial Catalog = InfiniteDb;" +
                "Integrated Security = true ;");
            conn.Open();
            return conn;
        }
    }
}

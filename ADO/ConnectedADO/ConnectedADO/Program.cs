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
            // InsertData();
            DeleteData();
            SelectData();
            //SelectData2();
            Console.Read();
        }

        static void DeleteData()
        {
            conn=getConnection();
            Console.WriteLine("Enter Employee no to delete :");
            int eid = int.Parse(Console.ReadLine());

            SqlCommand cmd1 = new SqlCommand("select * from tblemployee where empid = @eid");
            cmd1.Connection = conn;
            cmd1.Parameters.AddWithValue("@eid",eid);
            SqlDataReader dr = cmd1.ExecuteReader();

            while(dr.Read())
            {
                for(int i=0; i < dr.FieldCount;i++)
                {
                    Console.WriteLine(dr[i]);
                }
            }
            conn.Close();
            Console.WriteLine();

            Console.WriteLine("Are you sure to delete this Employee ? Y/N :");
            string answer = Console.ReadLine();
            if(answer == "Y" || answer == "y")
            {
                cmd = new SqlCommand("delete from tblemployee where empid = @eid", conn);
                cmd.Parameters.AddWithValue("@eid", eid);
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record deleted ...");
            }
        }
        static void SelectData2()
        {
            try
            {
                conn = getConnection();
                Console.WriteLine("Enter the Department no :");
                int deptid = int.Parse(Console.ReadLine());

                cmd = new SqlCommand("select * from tblemployee where departmentid = @deptid", conn);
                cmd.Parameters.AddWithValue("@deptid",deptid);
                dataReader = cmd.ExecuteReader();
                bool status = dataReader.HasRows;
                if(status)
                {
                    Console.WriteLine("Starting to Display Employees ...");
                    while(dataReader.Read())
                    {
                        Console.WriteLine("Employee Id : " + dataReader["empid"]);
                        Console.WriteLine("Employee Name : " + dataReader["empname"]);
                        Console.WriteLine("Employee Salary : " + dataReader["salary"]);
                        Console.WriteLine("Employee Dept : " + dataReader["departmentid"]);
                    }
                }
                else
                    Console.WriteLine("No Data Fetched");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void InsertData()
        {
            try
            {
                conn = getConnection();
                Console.WriteLine("Enter Employee Id, Name, Gender, Salary, DepartmentNo :");
                int eid =Convert.ToInt32(Console.ReadLine());
                string ename = Console.ReadLine();
                string egender = Console.ReadLine();
                decimal esal = Convert.ToDecimal(Console.ReadLine());
                int edid = Convert.ToInt32(Console.ReadLine());

                cmd = new SqlCommand("insert into tblemployee values(@eno,@name,@egen,@esalary,@edept)",conn); // sql parameter variables

                //bind or map, the csharp variables with data to sql parameters
                //use parameters collection of the command object

                cmd.Parameters.AddWithValue("@eno",eid);
                cmd.Parameters.AddWithValue("@name",ename);
                cmd.Parameters.AddWithValue("@egen",egender);
                cmd.Parameters.AddWithValue("@esalary",esal);
                cmd.Parameters.AddWithValue("@edept",edid);

               int result =  cmd.ExecuteNonQuery();
                if(result > 0 )
                {
                    Console.WriteLine("Record inserted successfully...");
                }
                else
                    Console.WriteLine("Could not insert record..");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
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
                    //Console.WriteLine(dataReader[0] + " " + dataReader[1] + " " + dataReader[2] + " "
                    //    + dataReader[3] + " " + dataReader[4]);
                    //Console.WriteLine("-------------------------");
                    Console.WriteLine(dataReader["empid"] +" " +  dataReader["empname"] +"  "+ dataReader["salary"] );
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;

namespace ConnectedADO
{
    //Business access layer
    class Region
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
        DataAccess access = new DataAccess();

        public SqlDataReader SelectRegion()
        {
            return access.SelectRegionData();
        }

        public int InsertRegion()
        {
            Console.WriteLine("Enter New Region ID :");
            RegionID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Region Description :");
            RegionDescription = Console.ReadLine(); 

            return access.AddRegion(RegionID, RegionDescription);
        }

        public int GetCount()
        {
            return access.GetRegionCount();
        }

        public void GetRegion()
        {
            access.GetRegion();
        }

        public SqlDataReader MostExpensive()
        {
            return access.MostExpensiveProducts();
        }

        public SqlDataReader CustomerOrders(string custid)
        {
            return access.CustomerOrders(custid);
        }

        public void GetCountOfEmployees(int did)
        {
            access.GetEmpCount(did);
        }
    }

    //Data Layer
    class DataAccess
    {
        static SqlConnection _conn = null;
        static SqlDataReader _reader = null;
        static SqlCommand _command = null;
        static int result;

        public SqlConnection getDBConnection()
        {
            string connect = "Data Source = Laptop-tjj7d977; Database= Northwind; trusted_connection =true;";
            _conn = new SqlConnection(connect);
            _conn.Open();
            return _conn;
        }

        public SqlDataReader SelectRegionData()
        {
            try
            {
                _conn = getDBConnection();

                _command = new SqlCommand("Select * from Region", _conn);
                _reader = _command.ExecuteReader();
                return _reader;
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return _reader;
        }

        public int AddRegion(int rid, string rdesc)
        {
            try
            {
                _conn = getDBConnection();
                _command = new SqlCommand("insert into region values(@rid,@rdesc)");
                _command.Connection = _conn;

                _command.Parameters.AddWithValue("@rid", rid);
                _command.Parameters.AddWithValue("@rdesc", rdesc);
                result = _command.ExecuteNonQuery();
            }

            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        //scalar functions

        public int GetRegionCount()
        {
            try
            {
                _conn = getDBConnection();
                _command = new SqlCommand("Select count(regionId) from region", _conn);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            return Convert.ToInt32( _command.ExecuteScalar());
        }

        //scalar that retrieves only the value at (0,0) index 
        public void GetRegion()
        {
            _conn = getDBConnection();
            _command = new SqlCommand("select * from Region",_conn);

            Console.WriteLine(_command.ExecuteScalar()); 
        }

        //calling procedure without parameters
        public SqlDataReader MostExpensiveProducts()
        {
            _conn = getDBConnection();
            _command = new SqlCommand("Ten Most Expensive Products", _conn);
            _command.CommandType = CommandType.StoredProcedure;

            //object obj = _command.ExecuteScalar().ToString();
            //    Console.WriteLine(obj);
            _reader = _command.ExecuteReader();
            return _reader;
        }

        //1. calling procedures with input parameter
        public SqlDataReader CustomerOrders(string cid)
        {
            _conn = getDBConnection();
            _command = new SqlCommand("custordersorders", _conn);

            _command.CommandType= CommandType.StoredProcedure;

            //option 1 to pass or bind parameters
            //_command.Parameters.AddWithValue("@customerid",cid);
            //_reader = _command.ExecuteReader();
            //return _reader;


            //option 2 using Sqlparameter class object

            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@customerid";
                param1.Value = cid;
                param1.DbType = DbType.String;
                param1.Direction = ParameterDirection.Input; 

            _command.Parameters.Add(param1);
            _reader = _command.ExecuteReader();
            return _reader;
        }

        //calling procedure with input, output, and return values
        public void GetEmpCount(int deptid)
        {
            _conn = new SqlConnection("Data Source=laptop-tjj7d977; initial catalog=infinitedb; trusted_connection=true;");
            _conn.Open();

            _command = new SqlCommand("sp_getempcount", _conn);
            _command.CommandType =CommandType.StoredProcedure;

            _command.Parameters.AddWithValue("@deptid", deptid);

            _command.Parameters.Add("@totsal",SqlDbType.Decimal).Direction = ParameterDirection.Output;
            _command.Parameters.Add("@count", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            _command.ExecuteNonQuery();

            //trying to retrieve the output and return values
            int retcount = (int)_command.Parameters["@count"].Value;
            decimal outsal = (decimal)_command.Parameters["@totsal"].Value;

            // Console.WriteLine("Total salary :" + );
            Console.WriteLine($"For the Dept : {deptid} , Total Salary is : {outsal} and the count of Employess : {retcount}");

        }
    }

    //client
    internal class ADO_Connected2
    {
        static void Main()
        {
            Region region = new Region();
            SqlDataReader dr = region.SelectRegion();
            Console.WriteLine("------------List of Regions------------");
            while (dr.Read())
            {
                Console.WriteLine($"Region ID : {dr["RegionID"]} Region Description : {dr["RegionDescription"]}");
            }

            //Console.WriteLine("----------Adding a New Region-----------");
            //int res = region.InsertRegion();
            //if(res > 0)
            //{
            //    Console.WriteLine("Added a Region..");
            //}
            //else
            //    Console.WriteLine("Failed to add a Region..");
            Console.WriteLine("----------Region Count--------------");

            Console.WriteLine(region.GetCount());
            Console.WriteLine("------Scalar Example--------");
            region.GetRegion();

            Console.WriteLine("-------Expensive Products---------");
            //  region.MostExpensive();
            dr = region.MostExpensive();
            while(dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1]);
            }
            Console.WriteLine("---------Customer Orders---------");
            Console.WriteLine("Enter Customer Id for the Orders :");
            string custid = Console.ReadLine();
            dr = region.CustomerOrders(custid);
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]+ " " + dr[3]);
            }

            Console.WriteLine("--------Procedure with all Parameters---------");
            Console.WriteLine("Enter the department id for the details :");
            int deptid = Convert.ToInt32(Console.ReadLine());
            region.GetCountOfEmployees(deptid);
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Transactions;

namespace ConnectionPooling
{
    internal class Program
    {
        public static string connectstr = "Data Source = Laptop-tjj7d977; Initial Catalog = Northwind;" +
            "Trusted_connection = true; Pooling = true;";
        static void Main(string[] args)
        {
            //var stopwatch = new Stopwatch();
            //stopwatch.Start();

            //for(int i=0; i<1000; i++)
            //{
            //    SqlConnection con = new SqlConnection(connectstr);
            //    con.Open();
            //    con.Close();
            //}
            //stopwatch.Stop();
            //Console.WriteLine($"The Time taken : {stopwatch.ElapsedMilliseconds} ms");

            //Transaction Function call
           // Transaction_Northwind(connectstr);
           Transaction_Scope(connectstr);
            Console.Read();
        }

        //Transaction Example
        public static void Transaction_Northwind(string str)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand(); // an sql command object is created and returned

                //for transaction

                SqlTransaction tran = con.BeginTransaction(); // associating a transaction object to the connection object
                cmd.Transaction = tran;
                try
                {
                    cmd.CommandText = "insert into region values(7,'Polar Region')";
                    cmd.ExecuteNonQuery();
                    //Console.WriteLine("Enter Region Description :");
                    //string rdesc = Console.ReadLine();
                    cmd.CommandText = "update region set regiondescription = 'Infinite Region' where regionid = 5";
                    cmd.ExecuteNonQuery();
                    tran.Commit();
                    Console.WriteLine("Transaction completed...");
                }
                catch(SqlException e)
                {
                    Console.WriteLine(e.Message  + " " + "Some Error Occurred..");
                    try
                    {
                        tran.Rollback();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }
        }

        //Transaction Scope Eg
        public static void Transaction_Scope(string str)
        {
            TransactionOptions options = new TransactionOptions();
            options.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;

            using(TransactionScope ts = new TransactionScope())
            {
                using(SqlConnection  con = new SqlConnection(str))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("Insert into region values(20,'New Dummy Region')",con))
                    {
                        try
                        {
                            int rowsaffected = cmd.ExecuteNonQuery();
                            if(rowsaffected > 0)
                            {
                                using(SqlConnection con1 = new SqlConnection(str))
                                {
                                    con1.Open();
                                    using(SqlCommand cmd1 = new SqlCommand("insert into shippers values('DTDC','(200) 657585')",con1))
                                    {
                                        int noofrows = cmd1.ExecuteNonQuery();
                                        if(noofrows > 0)
                                        {
                                            ts.Complete();
                                            Console.WriteLine("Transaction Successfull...");
                                            con1.Close();
                                        }
                                    }
                                }
                            }
                        }
                        catch(SqlException ex)
                        {
                            Console.WriteLine("Transaction Failed...");
                            ts.Dispose();
                        }
                    }
                    con.Close();
                }
            }
        }
    }
}

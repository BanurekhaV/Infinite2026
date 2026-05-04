using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingDataSets
{
    class Cust
    {
        public int CustomerId;
        public string CustomerName;
        public int AId;
    }
    internal class DataSets_Manipulations
    {
        public static void Main()
        {
            DataSet_Operations();
            Console.Read();
        }
        
        static void DataSet_Operations()
        {
            DataTable tableCust = new DataTable("Customers");
            tableCust.Columns.Add("CustomerId", typeof(int));
            tableCust.Columns.Add("CustomerName",typeof(string));
            tableCust.Columns.Add("AId",typeof(int));

            tableCust.Columns["AId"].AutoIncrement = true;
            tableCust.Columns["AId"].AutoIncrementSeed = 5;
            tableCust.Columns["AId"].AutoIncrementStep = 5;
            tableCust.Columns["AId"].ReadOnly = true;

            //populate data
            DataRow row = tableCust.NewRow();
            row["CustomerId"] = 1;
            row["CustomerName"] = "Infinite Ltd.";

            tableCust.Rows.Add(row);

            row = tableCust.NewRow();
            row["CustomerId"] = 4;
            row["CustomerName"] = "Wipro.,";

            tableCust.Rows.Add(row);

            row = tableCust.NewRow();
            row["CustomerId"] = 3;
            row["CustomerName"] = "TCS Ltd.,";

            tableCust.Rows.Add(row);

            row = tableCust.NewRow();
            row["CustomerId"] = 5;
            row["CustomerName"] = "CTS Ltd.";

            tableCust.Rows.Add(row);

            //create orders table

            DataTable tableOrders = new DataTable("Orders");
            tableOrders.Columns.Add("OrderId", typeof(int));
            tableOrders.Columns.Add("OrderValue", typeof(decimal));

            //setting primary key

            DataColumn[] pk = new DataColumn[0];
            tableOrders.PrimaryKey = pk;  
            
            DataRow r = tableOrders.NewRow();
            r["OrderId"] = 100;
            r["OrderValue"] = 25000.75;

            tableOrders.Rows.Add(r);

            //filtering 

            DataRow[] result = tableCust.Select("CustomerId > 2", "CustomerId desc");


            foreach(DataRow dr in result)
            {
                Console.WriteLine(dr["CustomerId"] + " " + dr["CustomerName"] + " " + dr["AId"]);
            }

            Console.WriteLine( "-------------- Sorting on Names ----------------");

            //sorting on custnames

            DataView view = tableCust.DefaultView;
            view.Sort = "CustomerName";
            DataTable sortedTable = view.ToTable();


            tableCust.DefaultView.Sort = "CustomerName";
            

            foreach (DataRow dr1 in sortedTable.Rows)
            {
                Console.WriteLine(dr1["CustomerId"] + " " + dr1["CustomerName"] + " " + dr1["AId"]);
            }


            //modify values in data table
            Console.WriteLine("------------  Modifications ----------");
            tableCust.Rows[3]["CustomerName"] = "NIIT Ltd.,";

            tableCust.AcceptChanges();

            foreach (DataRow dr1 in tableCust.Rows)
            {
                Console.WriteLine(dr1["CustomerId"] + " " + dr1["CustomerName"] + " " + dr1["AId"]);
            }


            //deleting data from a datatable
            Console.WriteLine("----------- deleting a row ----------");
            tableCust.Rows[0].Delete();

            tableCust.AcceptChanges();

            foreach (DataRow dr1 in tableCust.Rows)
            {
                Console.WriteLine(dr1["CustomerId"] + " " + dr1["CustomerName"] + " " + dr1["AId"]);
            }

            //converting the datatble to a list
            Console.WriteLine("-------------- Data Table to a List ------------");
            List<DataRow> list = tableCust.AsEnumerable().ToList();

            foreach(DataRow item in list)
            {
                Console.WriteLine(item["CustomerId"] + " " + item["CustomerName"] + " " + item["AId"]) ;
            }
            Console.WriteLine("============ Lamba Output ============");

            var custlist = tableCust.AsEnumerable().Select(r1 => new Cust
            {
                CustomerId = r1.Field<int>("CustomerId"),
                CustomerName = r1.Field<string>("CustomerName"),
                AId =r1.Field<int>("AId")
            }).ToList();

            foreach (var item in custlist)
            {
                Console.WriteLine(item.CustomerId + " " + item.CustomerName + " " + item.AId);                     
            }
            Console.WriteLine("************  XML Visual ************");

            DataSet ds = new DataSet("CustOrders");
            ds.Tables.Add(tableCust);
            ds.Tables.Add(tableOrders);

            Console.WriteLine(ds.GetXml());
            Console.WriteLine("$$$$$$$$$$   XML Schema  $$$$$$$$$$$$$$$");
            Console.WriteLine(ds.GetXmlSchema());
        }
    }
}

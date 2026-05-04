using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BuildingDataSets
{
    internal class Program
    {
        static void DataSet_Build()
        {
            //1. let us create a datatset (in-memory cache)
            DataSet dsEmployement = new DataSet("Employment");

            //2. add Data Table 1
            DataTable dtEmployees = new DataTable("Employees");

            //3. add columns to the data table 1
            DataColumn[] dcEmployees = new DataColumn[4];

            //4. Create Column details
            dcEmployees[0] = new DataColumn("EmpCode", System.Type.GetType("System.Int32"));
            dcEmployees[1] = new DataColumn("EmpName", System.Type.GetType("System.String"));
            dcEmployees[2] = new DataColumn("EmpDept", System.Type.GetType("System.String"));
            dcEmployees[3] = new DataColumn("EmpStatusId", System.Type.GetType("System.Int32"));

            //5. add the above columns to the datatable 1
            dtEmployees.Columns.Add(dcEmployees[0]);
            dtEmployees.Columns.Add(dcEmployees[1]);
            dtEmployees.Columns.Add(dcEmployees[2]);
            dtEmployees.Columns.Add(dcEmployees[3]);

            //6. add rows with data to the data table
            DataRow drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "1";
            drEmpRows["EmpName"] = "Rajesh";
            drEmpRows["EmpDept"] = "IT";
            drEmpRows["EmpStatusId"] = "1";

            //7. add the new row to the datatable collections

            dtEmployees.Rows.Add(drEmpRows);

            //repeat step 6 and 7 for that many no.of rows
            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "2";
            drEmpRows["EmpName"] = "Brijesh";
            drEmpRows["EmpDept"] = "Finance";
            drEmpRows["EmpStatusId"] = "3";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "3";
            drEmpRows["EmpName"] = "Ramya";
            drEmpRows["EmpDept"] = "Accounts";
            drEmpRows["EmpStatusId"] = "1";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "4";
            drEmpRows["EmpName"] = "Divya";
            drEmpRows["EmpDept"] = "Testing";
            drEmpRows["EmpStatusId"] = "3";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "5";
            drEmpRows["EmpName"] = "Sowmya";
            drEmpRows["EmpDept"] = "Accounts";
            drEmpRows["EmpStatusId"] = "4";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpCode"] = "6";
            drEmpRows["EmpName"] = "Priya";
            drEmpRows["EmpDept"] = "Operations";
            drEmpRows["EmpStatusId"] = "4";

            dtEmployees.Rows.Add(drEmpRows);

            //8. create another datatable
            DataTable dtEmpStatus = new DataTable("EmployeeStatus");

            //9. create colomns for datatable 2
            DataColumn[] dcStatus = new DataColumn[2];

            dcStatus[0] = new DataColumn("EmpStatusId", System.Type.GetType("System.Int32"));
            dcStatus[1] = new DataColumn("EmpStatus", System.Type.GetType("System.String"));

            //10 attach the columns to the table 2
            dtEmpStatus.Columns.Add(dcStatus[0]);
            dtEmpStatus.Columns.Add(dcStatus[1]);

            //11. Rows for the datatable 2
            DataRow drStatusRows = dtEmpStatus.NewRow();

            //12. give data to the columns

            drStatusRows["EmpStatusId"] = "1";
            drStatusRows["EmpStatus"] = "Full Time";

            //13. add the row to the table
            dtEmpStatus.Rows.Add(drStatusRows);

            //repeat 12 and 13
            drStatusRows = dtEmpStatus.NewRow();

            drStatusRows["EmpStatusId"] = "2";
            drStatusRows["EmpStatus"] = "Part Time";

            dtEmpStatus.Rows.Add(drStatusRows);

            drStatusRows = dtEmpStatus.NewRow();

            drStatusRows["EmpStatusId"] = "3";
            drStatusRows["EmpStatus"] = "Contract";

            dtEmpStatus.Rows.Add(drStatusRows);

            drStatusRows = dtEmpStatus.NewRow();

            drStatusRows["EmpStatusId"] = "4";
            drStatusRows["EmpStatus"] = "Intern";

            dtEmpStatus.Rows.Add(drStatusRows);

            //14. add both data tables to the dataset
            dsEmployement.Tables.Add(dtEmployees);
            dsEmployement.Tables.Add(dtEmpStatus);

            //15 associate both the tables using PK and FK

            //15.1 to create a PK and FK
            DataColumn parent = dsEmployement.Tables["EmployeeStatus"].Columns["EmpStatusId"];

            DataColumn child = dsEmployement.Tables["Employees"].Columns["EmpStatusId"];

            //15.2 set the relation
            DataRelation EmpRel = new DataRelation("EmpStatusRelation", parent, child);

            //15.3 add the raletionship to the dataset
            dsEmployement.Relations.Add(EmpRel);

            //16 . Display the data accordingly
            Console.WriteLine("*******************************************************************************************" );

            Console.WriteLine("Status Id                        |                 Employee Status");
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            foreach(DataRow row in dsEmployement.Tables["EmployeeStatus"].Rows)
                Console.WriteLine("{0}                |                    {1}", row["EmpStatusId"], row["EmpStatus"]);

            Console.WriteLine("------------------------------------------------------------------------------------------------");

            foreach (DataRow row1 in dsEmployement.Tables["Employees"].Rows)
            {
                Console.WriteLine("{0}\t   |    {1}\t     |{2}\t        |        {3}\t", row1["EmpCode"], row1["Empname"],
                    row1["EmpDept"], row1["EmpStatusId"]);
            }

                Console.WriteLine("---------- Empstatus instead of Ids --------");

            foreach (DataRow row1 in dsEmployement.Tables["Employees"].Rows)
            {
                int irow = int.Parse(row1["EmpStatusId"].ToString());
                //Console.WriteLine(irow);
                DataRow currentrow = dsEmployement.Tables["EmployeeStatus"].Rows[irow -1];
                Console.WriteLine("{0}\t   |    {1}\t     |{2}\t        |        {3}\t", row1["EmpCode"], row1["Empname"],
                   row1["EmpDept"], currentrow["EmpStatus"]);
            }
            Console.WriteLine();
            Console.WriteLine("------------ By Matching the Rows ----------");

            foreach(DataRow dr in dtEmpStatus.Rows)
            {
                foreach(DataRow dr2 in dtEmployees.Rows)
                {
                    int stsid = dr.Field<int>("EmpStatusId");
                    int empstsid = dr2.Field<int>("EmpStatusId");

                    string status = dr.Field<string>("EmpStatus");

                    if(stsid == empstsid)
                    {
                        Console.WriteLine("{0}\t   |    {1}\t     |{2}\t        |        {3}\t", dr2["EmpCode"], dr2["Empname"],
                   dr2["EmpDept"], status);
                    }
                }
            }


        }
        static void Main(string[] args)
        {
            DataSet_Build();
            Console.Read();
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingDataSets
{
    internal class DataConstraints
    {
        static void Main()
        {
            OurDataConstraints();
            Console.Read();
        }

        static void OurDataConstraints()
        {
            DataSet ds = new DataSet();

            DataTable ClassTable = ds.Tables.Add("OurClass");

            ClassTable.Columns.Add("CID", typeof(int));
            ClassTable.Columns.Add("ClassName", typeof(string));

            DataTable StudentTable = ds.Tables.Add("Students");

            StudentTable.Columns.Add("SID", typeof(int));
            StudentTable.Columns.Add("SName", typeof(string));
            StudentTable.Columns.Add("ClassID", typeof(int));

            //intialize PK constraint

            ClassTable.PrimaryKey = new DataColumn[] { ClassTable.Columns["CID"] };

            //adding relation to the dataset
            ds.Relations.Add("Class_student", ClassTable.Columns["CID"], StudentTable.Columns["ClassID"]);

            //set the foreign key
            DataColumn dcclassid = ds.Tables["OurClass"].Columns["CID"];
            DataColumn dcstudent = ds.Tables["Students"].Columns["ClassID"];

            ForeignKeyConstraint fkc = new ForeignKeyConstraint("csfkc", dcclassid, dcstudent);

            //we can set the rules for foreign key

            fkc.DeleteRule = Rule.SetNull;
            fkc.UpdateRule = Rule.Cascade;

            //we can have unique constraint

            UniqueConstraint ucnames = new UniqueConstraint(new DataColumn[] { ClassTable.Columns["ClassName"] });

            ds.Tables["OurClass"].Constraints.Add(ucnames);

            //now let us check the constraints we specified

            DataRow dr = ds.Tables["Ourclass"].NewRow();

            dr["CID"] = 1;
            dr["ClassName"] = null;

            ClassTable.Rows.Add(dr);

            //2nd row

            dr = ds.Tables["Ourclass"].NewRow();

            dr["CID"] = 2;
            dr["ClassName"] = "Sixth";

            ClassTable.Rows.Add(dr);

            //student table testing

            DataRow dr2 = ds.Tables["Students"].NewRow();
            dr2["SID"] = 1;
            dr2["SName"] = "Babitha";
            dr2["ClassId"] = 2;

            StudentTable.Rows.Add(dr2);

        }
    }
}

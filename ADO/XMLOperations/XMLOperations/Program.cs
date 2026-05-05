using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Xml;

namespace XMLOperations
{
    internal class Program
    {
        static DataSet ds = new DataSet("DS");
        static void Main(string[] args)
        {
           // XmlWriter();
            XmlReader();
            Console.WriteLine("------------------------"); 
            XmlSchemaWriter();
            Console.WriteLine("------------------------");
            XmlSchemaReader();
            Console.Read();
        }

        static void ContentGeneration()
        {
            ds.Namespace = "StudentsSpace";
            DataTable stdTable = new DataTable("Students");

            stdTable.Columns.Add("Id",typeof(int));
            stdTable.Columns.Add("Name",typeof(string));
            stdTable.Columns.Add("Address", typeof(string));

            DataRow dataRow = stdTable.NewRow();

            dataRow["Id"] = 10;
            dataRow["Name"] = "Mohan";
            dataRow["Address"] = "Bangalore";

            stdTable.Rows.Add(dataRow);

            dataRow = stdTable.NewRow();

            dataRow["Id"] = 12;
            dataRow["Name"] = "Rohan";
            dataRow["Address"] = "Mumbai";

            stdTable.Rows.Add(dataRow);

            dataRow = stdTable.NewRow();

            dataRow["Id"] = 14;
            dataRow["Name"] = "Sohan";
            dataRow["Address"] = "Hyderabad";

            stdTable.Rows.Add(dataRow);

            dataRow = stdTable.NewRow();

            dataRow["Id"] = 16;
            dataRow["Name"] = "Jagan";
            dataRow["Address"] = "Chennai";

            stdTable.Rows.Add(dataRow);

            //add the datatble to the dataset

            ds.Tables.Add(stdTable);
            ds.AcceptChanges();
           
        }
        static void XmlWriter()
        {
            try
            {
                ContentGeneration();
                StreamWriter sw = new StreamWriter("Student.xml");

                ds.WriteXml(sw);
                sw.Close();
                Console.WriteLine("Xml file Created successfully...");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void XmlReader()
        {
            DataSet ds1 = new DataSet();
            ds1.ReadXml("Student.xml");

            foreach(DataTable dt in ds1.Tables)
            {
                Console.WriteLine(dt);

                for(int i=0; i<dt.Columns.Count; i++)
                {
                    Console.Write("\t" + "\t" + dt.Columns[i].ColumnName);
                }
                Console.WriteLine();

                foreach(DataRow row in dt.Rows)
                {
                    for(int j=0; j<dt.Columns.Count; j++)
                    {
                        Console.Write("\t" + "\t" + row[j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("----------------------------------------------------------");
            
                foreach(var r in dt.AsEnumerable())
                {
                    for(int i = 0; i<dt.Columns.Count; i++)
                    {
                        Console.Write("\t" + "\t" + r[i]);
                    }
                    Console.WriteLine();
                }
            }
        }
        static void XmlSchemaWriter()
        {
            ContentGeneration();
            ds.WriteXmlSchema("Studentschema");
            Console.WriteLine("Xml schema Created successfully...");
        }
        static void XmlSchemaReader()
        {
            ds = new DataSet("StdSchema");

            StreamReader sr = new StreamReader("Studentschema");

            ds.ReadXmlSchema(sr);

            //use foreach loop to iterate the dataset

            //we can also use xmltextwriter
            XmlTextWriter writer = new XmlTextWriter(Console.Out);
            ds.WriteXmlSchema(writer);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;


namespace Day11
{
    [Serializable]   //attributes/annotations/metatdata/decorator
    class Products
    {
        public int ProductId;
        public string ProductName;
        public float ProductPrice;
        [NonSerialized]  // non serializable field in a serializable object
        public double TotalSales;
    }

    public class Customers
    {
        public string CustId;
        public string CustName;
    }

    public class Books
    {
       [XmlElementAttribute("BookName")] public string bookname;
        [XmlElementAttribute] public string AuthorName;
        [XmlElementAttribute("YearofPublishing")] public int YearPublished;

        public Books() { }
        public Books(string bname, string aname, int yr) 
        {
            bookname = bname;
            AuthorName = aname;
            YearPublished = yr;
        }
    }

    [Serializable]
    class EmployeeDetails
    {
        public string EName ="";
        public string Street="";
        public string City="";

        //returns the JSON serialization of the object as a string
        public string ToJson()
        {
            //Make a memorystream to serialize
            using (MemoryStream ms = new MemoryStream())
            {
                DataContractJsonSerializer dataContractJson = new DataContractJsonSerializer(typeof(EmployeeDetails));
                dataContractJson.WriteObject(ms, this);
                ms.Flush();

                //get the results of serialization from the stream as a text
                ms.Seek(0, SeekOrigin.Begin);
                using (StreamReader sr = new StreamReader(ms))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        public static EmployeeDetails FromJson(string json)
        {
            //make a stream to read from
            MemoryStream ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);
            sw.Write(json);
            sw.Flush();

            ms.Position = 0;

            //deserialize from the stream
            DataContractJsonSerializer dc = new DataContractJsonSerializer(typeof(EmployeeDetails));

            EmployeeDetails receiver = (EmployeeDetails)dc.ReadObject(ms);
            return receiver;
        }
    }
    internal class SerializationEg
    {
        static void Main()
        {
            // BinarySerializationEg();
            // XMlSerializationEg();
            //XmlSerialization2();
            JsonSerializationEg();
            Console.Read();
        }

        
        public static void JsonSerializationEg()
        {
            EmployeeDetails emp = new EmployeeDetails()
            {
                EName = "Brinda",
                Street = "Downing Street",
                City = "New York"
            };

            //call for serialization
            string serializeddata = emp.ToJson();
            Console.WriteLine(serializeddata); //{"ename" : "banurekha", "salary":45000 }

            //call to deserialize
            EmployeeDetails employeeDetails = EmployeeDetails.FromJson(serializeddata);
            Console.WriteLine(employeeDetails.EName + " "+ employeeDetails.City + " " + employeeDetails.Street);
        }
        public static void XMlSerializationEg()
        {
            //to serialize
            Customers cust = new Customers() { CustId = "C001", CustName = "Infinite Ltd." };
            XmlSerializer x = new XmlSerializer(cust.GetType());
            x.Serialize(Console.Out, cust);
            Console.WriteLine();

            Console.WriteLine("--------Deserialization 1----------");

            string xData = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<Customers xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n   <CustId>C001</CustId>\r\n   <CustName>Infinite Ltd.</CustName>\r\n</Customers>";

            XmlSerializer x1 = new XmlSerializer(typeof(Customers));

            Customers Cust2 = (Customers)x1.Deserialize(new StringReader(xData));
            Console.WriteLine("Customer Id : " + Cust2.CustId);
            Console.WriteLine("Customer Name : " + Cust2.CustName);

        }

        public static void XmlSerialization2()
        {
            Books books = new Books("Seetha - The Warrior of Mithila", "Amish Tripathi", 2010);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Books));

            StreamWriter writer = new StreamWriter("Books.xml");
            xmlSerializer.Serialize(writer, books);
            writer.Close();

            Console.WriteLine("------------Deserialization from file ------------");

           // Books book2 = new Books();

            xmlSerializer = new XmlSerializer(typeof(Books));
            StreamReader reader = new StreamReader("Books.xml");
            Books book2 = (Books)xmlSerializer.Deserialize(reader);
            reader.Close();
            Console.WriteLine($"Book name is {book2.bookname} AuthorName is :{book2.AuthorName}" +
                $" and the year of publication is :{book2.YearPublished}");
        }
        public static void BinarySerializationEg()
        {
            Products products = new Products()
            {
                ProductId = 1,
                ProductName = "Mobile Phones",
                ProductPrice = 32000,
                TotalSales = 5000000.00
            };

            IFormatter formater = new BinaryFormatter();
            // BinaryFormatter binform = new BinaryFormatter();

            Stream stream = new FileStream("Productfile.txt", FileMode.Create, FileAccess.Write);
            formater.Serialize(stream, products);
            stream.Close();


            //deserialization

            stream = new FileStream("Productfile.txt", FileMode.Open, FileAccess.Read);

            Products products1 = (Products)formater.Deserialize(stream);

            Console.WriteLine("Name : " + products1.ProductName + " Price : " + products1.ProductPrice + " Total : " + products1.TotalSales);
        }
    }
}

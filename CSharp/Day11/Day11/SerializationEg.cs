using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


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
    internal class SerializationEg
    {
        static void Main()
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
            Console.Read();
        }
    }
}

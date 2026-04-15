using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get a singleton instance
            SingletonCache scache = SingletonCache.GetInstance();

            //adding keys and values to the concurrent dictionary
            Console.WriteLine("Adding Keys and Values to the Cache");
            Console.WriteLine($"Adding Id to the Cache {scache.Add("Id",1001)}");
            Console.WriteLine($"Adding Name to the Cache {scache.Add("Name","Sukanya")}");

            Console.WriteLine($"Adding same Id to the Cache using Add {scache.Add("Id", 2001)}");

            Console.WriteLine($"Adding same Id to the Cache using Addorupdate {scache.AddorUpdate("Id", 2001)}");

            Console.WriteLine($"Fetching values from the Cache :");
            Console.WriteLine($"Fetching Id from cache : {scache.Get("Id")}");

            Console.WriteLine($"Fetching Name from cache : {scache.Get("Name")}");

            Console.WriteLine($"Remove an Id : {scache.Remove("Id")}");

            Console.WriteLine($"Trying to access removed Key : {scache.Get("Id")}");

            
            Console.WriteLine($"Fetching Name from cache : {scache.Get("Name")}");
            scache.Clear();
            Console.Read();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class DictionaryEg
    {
        static void Main()
        {
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "Red");
            dict.Add(2, "Blue");
            dict.Add('A', "Green");
            dict.Add(3, "Yellow");

            foreach(int item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (string item in dict.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach(KeyValuePair<int,string> pair in dict)
            {
                Console.Write(pair.Key + " ");
                Console.Write(pair.Value);
                Console.WriteLine();
            }           
             
            Console.Read();
        }
    }
}

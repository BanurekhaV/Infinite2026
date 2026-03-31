using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class CollectionEg
    {
        static void Main()
        {
            // ArrayListEg();
            HashTableEg();
            Console.Read();
        }

        public static void ArrayListEg()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1); 
            arrayList.Add("AAA");
            arrayList.Add('Z');
            arrayList.Add(true);
            arrayList.Add(456.745f);
            arrayList.Add("Rama");
            arrayList.Add(125000.00);
            arrayList.Add('A');
            //arrayList.Add(false);

            //to insert an element at a particular index
            arrayList.Insert(3, "Seetha");

            foreach (var v in arrayList)
            {
                Console.WriteLine(v);
            }
            //to remove a value from the collection
            arrayList.Remove('A');

            arrayList.RemoveAt(4);  // removing an element at an index location

            foreach (var v in arrayList)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine($"Count : {arrayList.Count} and Capacity : {arrayList.Capacity}" );

            //insert range
            ArrayList al2 = new ArrayList();
            al2.Add(12);
            al2.Add(4);
            al2.Add(6);
            al2.Add(18);

            arrayList.InsertRange(0, al2);
            foreach (var v in arrayList)
            {
                Console.WriteLine(v);
            }

            //issues with arraylist of different data types
            //arrayList.Sort();
            al2.Sort();

            foreach (var v in al2)
            {
                Console.WriteLine(v);
            }
        }

        public static void HashTableEg()
        {
            Hashtable ht = new Hashtable();
            ht.Add("E005", "Praveen");
            ht.Add("E001", "Arun");
            ht.Add("E006", "Kishore");
            ht.Add("E002", "Arun");
            ht.Add("E008", null);

            //1. iterating using keys
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }

            //2. iterating using values
            Console.WriteLine("-------------------");
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }

            //3. iterating the whole object, using DictionaryEntry
            foreach(DictionaryEntry de in ht)
            {
                Console.Write(de.Key + " " );
                Console.Write(de.Value);
                Console.WriteLine();
            }

            //hashtables are used to store large records,
            // retrieving by searching is very good with hashtable

            Console.WriteLine("Enter a Key to search :");
            string ekey = Console.ReadLine();

            if(ht.ContainsKey(ekey))
            {
                Console.WriteLine(ekey  + "is = " + ht[ekey] );
            }
            else
                Console.WriteLine("Employee with Key does not exists");
        }
        public static void SortedList()
        {
            SortedList sl = new SortedList();
        }
    }
}

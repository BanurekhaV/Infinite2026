using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lstweekdays = new List<string>()
            {
             "Sunday", "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"
            };

            //let us create IEnumerable on the list
            IEnumerable<string> enumerableweekdays = lstweekdays;

            //now we will retrieve the data
            foreach(string s in enumerableweekdays)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------------using IEnumerator------------");
            IEnumerator<string> enumeratorweekdays = lstweekdays.GetEnumerator();

            while (enumeratorweekdays.MoveNext())
            {
                Console.WriteLine(enumeratorweekdays.Current);
            }
            Console.Read();
        }
    }
}

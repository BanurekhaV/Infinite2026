using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{

    internal class IListEg
    {
        public static void Show(IList<string> lst)
        {
            foreach (string str in lst)
            {
                Console.WriteLine("\t" + str);
            }
        }
    }

    class TestIList
    {
        static void Main()
        {
            string[] courses = { "CSharp", "Sql", "ADO", "ASP" };

            List<string> list = new List<string>();
            list.Add("30 hrs");
            list.Add("20 hrs");
            list.Add("10 hrs");
            list.Add("30 hrs");

            Console.WriteLine("Course Names: ");
            IListEg.Show(courses);

            Console.WriteLine("Duration of Courses :");
            IListEg.Show(list);

            Console.Read();
        }
    }
}

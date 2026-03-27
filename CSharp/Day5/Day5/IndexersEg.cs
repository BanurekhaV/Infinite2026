using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Users
    {
        //declaring an array field
        string[] UserName = new string[3];

        //define indexer for the array field
        public string this[int i]
        {
            get { return UserName[i]; }
            set
            {
                UserName[i] = value;
            }
        }

        //overloading the indexer
        public string this[string s]
        {
            get
            {
                foreach(string str in UserName)
                {
                    if (str.ToLower() == s.ToLower())
                    {
                        return str.ToUpper();
                    }
                }
                return null;
            }
        }
    }

    class Subjects
    {
        private string[] module = new string[3];

        public string this[int x]
        {
            get { return module[x]; }
            set { module[x] = value; }
        }

        //overloading

        public string this[float f]
        {
            get { return module[(int)f]; }
            set { module[(int)f] = value; }
        }

        public string this[string s]
        {
            get
            {
                return module[Convert.ToInt32(s)];
            }
            set { module[Convert.ToInt32(s)] = value; }
        }
    }
    internal class IndexersEg
    {
        static void Main()
        {
            Users users = new Users();

            //setting values using integer indexer
            users[0] = "Baraniharan";
            users[1] = "Athul";
            users[2] = "Suriya";

            //accessing the indexer using integer index
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("User Name {0} is : {1} ",i +1,users[i]);
            }
            Console.WriteLine("------------Accessing the string Indexer--------------");
            Console.WriteLine(users["Baraniharan"]);
            Console.WriteLine(users["Athul"]);
            Console.WriteLine(users["Suriya"]);

            Console.WriteLine(users["Testing"]);

            Console.WriteLine("============ Example 2 of Indexer ==========");
            Subjects subjects = new Subjects();
            subjects[0] = "C#";
            subjects[1] = "Sql";
            subjects[2] = "Html";

            Console.WriteLine(subjects[0] + " " + subjects[1] + " " + subjects[2]);

            subjects[0.1f] = "CSharp";
            subjects[1.1f] = "SQL";
            subjects[2.1f] = "HTML";

            Console.WriteLine(subjects[0.1f] + " " + subjects[1.1f] + " " + subjects[2.1f]);

            subjects["0"] = "ADO";
            subjects["1"] = "XML";
            subjects["2"] = "LINQ";

            Console.WriteLine(subjects["0"] + " " + subjects["1"] + " " + subjects["2"]);

            Console.Read();
        }
    }
}

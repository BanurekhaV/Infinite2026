using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public delegate string MyDelegate(string str);
    internal class Events_EgEasy
    {
        event MyDelegate MyEvent;
        event MyDelegate MyEvent2;

        public Events_EgEasy()
        {
            this.MyEvent += new MyDelegate(this.GreetUser);
            this.MyEvent2 = new MyDelegate(this.WelcomeUser);            
        }

        public string GreetUser(string s)
        {
            return "Hello and Welcome " + s;
        }
        public string WelcomeUser(string str)
        {
            return "Welcome " + str;
        }

        static void Main(string[] args)
        {
            Events_EgEasy events_EgEasy = new Events_EgEasy();
            string result = events_EgEasy.MyEvent("Infinite Associates..");
            string res = events_EgEasy.MyEvent2("Event two");
            Console.WriteLine(result);
            Console.WriteLine(res);
            Console.Read();
        }
    }

}

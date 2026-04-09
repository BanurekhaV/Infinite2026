using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    partial class Students
    {
        string Name;
        public string _Name
        {
            get { return Name; }
            set { Name = value;
                onNameChanged();   // calling partial method
            }
        }

        //partial method declaration
        
         partial void onNameChanged();
         partial void NameinCaps();
    }

    partial class Students
    {
        //implementation of partial method
      
        partial void onNameChanged()
        {
            Console.WriteLine("Name has been changed to : " + Name);
        }

    }

    class Driverclass
    {
        static void Main()
        {
            Students students = new Students();
            students._Name = "Barani";
            students._Name = "Karthik";
            Console.Read();
        }
    }
}

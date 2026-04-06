using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    public class Person {
       public int pId = 10;
    }
    public class Employee : Person {
        public int EId = 20;
    }

    public class Manager : Employee { }    

    delegate void personDelegate(Employee e);
    
    internal class Program
    {
        public static void Message(Person pobj)
        {
            Console.WriteLine("Hi I am Less Derived but Big Object here... " + pobj.pId);
        }
        static void Main(string[] args)
        {
            Person pobj = new Person();
            var empobj = new Employee();
            var mgrobj = new Manager();

            pobj = empobj;
            pobj = mgrobj;

            empobj = (Employee)pobj;  //contravariance
            Console.WriteLine(empobj.EId);
            //contavariance in function parameters
            personDelegate pd = Message;
            pd(empobj);

            //covariance in arrays
            Person[] p1 = new Employee[3];
            p1[0] = new Manager();

            //contravariance in arrays
            Person[] p2 = {new Person()};
            //  Employee[] emp = p2; 
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Account 
    {
        public int Id;
        public string Name;
        public static float rateofinterest;

        //1. instance constructor
        public Account(int id, string name)
        {
            Console.WriteLine("Instance constructor called..");
            this.Id = id;
            this.Name = name;
           // rateofinterest = 6.5f;
        }

        //static constructor
         static Account() 
         {
            Console.WriteLine("Static constructor called ...");
            rateofinterest = 7.5f;
            Console.WriteLine(rateofinterest);
         }

        public void DisplayAccount()
        {
            Console.WriteLine(Id + " " + Name + " " + rateofinterest);           
        }
    }

    //protected constructor example
    class Dog
    {
        public string Name;
        public int Age;

        protected Dog()
        {
            Console.WriteLine("We are in the process of constructing a Dog...");
            Console.WriteLine(Name  + " " + Age);
        }
    }

    class Labrador : Dog
    {
        public double measurements;

        public Labrador(string name, int age,double measurements)
        {
            Console.WriteLine("Labrador under Construction....");
            Name = name;
            Age = age;
            this.measurements = measurements;
            Console.WriteLine(Name + " " + Age + " " + measurements);
        }
    }
    internal class ConstructorTypes
    {
        static void Main()
        {
            Account a1 = new Account(101, "Suriya");
            Account a2 = new Account(102, "Arul");

            a1.DisplayAccount();
            a2.DisplayAccount();
            Console.WriteLine("---------Protected Constructor Example ---------");

            //invoking protected constructor of the base class thru derived class
            Labrador lb = new Labrador("Tuffy", 5, 12.5);


            Console.Read();
        }
    }
}

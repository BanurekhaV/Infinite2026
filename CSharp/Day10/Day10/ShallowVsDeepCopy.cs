using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Person
    {
        public int Age;
        public PersonDescription Description;

        public Person(int a, string fn, string ln) 
        { 
            Age = a;
            Description = new PersonDescription(fn, ln);
        }

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person dcopy = new Person(this.Age, Description.FirstName, Description.LastName);
            return dcopy;
        }
    }

    class PersonDescription
    {
        public string FirstName;
        public string LastName;

        public PersonDescription(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
    internal class ShallowVsDeepCopy
    {
        static void Main()
        {
            Person person1 = new Person(15, "Steve", "Jobbs");
            Person person2 = (Person)person1.ShallowCopy();

            Console.WriteLine(person1.Age + " " + person1.Description.FirstName);
            Console.WriteLine(person2.Age + " " +  person2.Description.FirstName);

            person2.Description.FirstName = "Henry";
            Console.WriteLine(person1.Description.FirstName);
            Console.WriteLine(person2.Description.FirstName);

            //deep copy , data would not change
            Person person3 = person1.DeepCopy();
            Console.WriteLine(person1.Age + " " + person1.Description.FirstName + " " + person1.Description.LastName);
            Console.WriteLine(person3.Age + " " + person3.Description.FirstName + " " + person3.Description.LastName);

            person3.Description.LastName = "Stone";

            Console.WriteLine(person1.Age + " " + person1.Description.FirstName + " " + person1.Description.LastName);
            Console.WriteLine(person3.Age + " " + person3.Description.FirstName + " " + person3.Description.LastName);
            Console.Read();
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    interface IName
    {
        string Name { get; set; }
        int Age { get; set; }
        
    }

    class Employee : IName
    {
        public string Name { get; set; }
        public int Age { get; set; } 
        
        public string Myphone {  get; set; }  // property of the employee class
    }

    class Company: IName
    {
        private string _companyName;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
    }
    internal class Interface_with_Properties
    {
        static void Main()
        {
            IName e = new Employee();
            e.Name = "VishnuPriya";
            
            //class property accessed via class object and cannot be accesed via interface object
            Employee emp = new Employee();
            emp.Myphone = "1234567891";
            Console.WriteLine(emp.Myphone);

            IName c = new Company();
            c.Name = " Infinite Ltd.";
            c.Age = 20;
            Console.WriteLine("{0} works for {1} which is {2} years old", e.Name, c.Name,c.Age);
                           
            Console.Read();
        }
    }
}

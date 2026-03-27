using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobDescription { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        //declaring indexer for the class employee

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Id;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return JobDescription;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Department;
                else return null;
            }
            set
            {
                if (index == 0)
                    Id = Convert.ToInt32(value);
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    JobDescription = value.ToString();
                else if (index == 3)
                    Salary = Convert.ToDouble(value);
                else if (index == 4)
                    Department = value.ToString();
            }
        }

        //overloading the above indexer
        public object this[string index]
        {
            get
            {
                if (index.ToLower() == "id")
                    return Id;
                else if (index.ToLower() == "name")
                    return Name;
                else if (index.ToLower() == "jobdescription")
                    return JobDescription;
                else if (index.ToLower() == "salary")
                    return Salary;
                else if (index.ToLower() == "department")
                    return Department;
                else
                    return null;
            }
            set
            {
                if (index == "Id")
                    Id = Convert.ToInt32(value);
                else if ((index == "Name") || (index == "name"))
                    Name = value.ToString();
                else if (index == "JobDescription")
                    JobDescription = value.ToString();
                else if (index == "Salary")
                    Salary = Convert.ToDouble(value);
                else if (index == "Department")
                    Department = value.ToString();
            }
        }
    }
        internal class IndexersEg3
        {
            static void Main()
            {
                Employees employee = new Employees
                {
                    Id = 1,
                    Name = "Deepak",
                    JobDescription = "Software Engineer",
                    Salary = 45000.50,
                    Department = "IT"
                };

                Console.WriteLine("Employee Id = " + employee[0]);
                Console.WriteLine("Employee Name = " + employee[1]);
                Console.WriteLine("Employee Salary = " + employee[3]);
                Console.WriteLine("Employee Dept = " + employee[4]);

                employee[1] = "Arul";
                Console.WriteLine("Employee Name = " + employee[1]);

                Console.WriteLine("----------With string indexer----------");
                employee["Id"] = 10;
                employee["Name"] = "Banurekha";

                Console.WriteLine(employee["id"] + " " + employee["Name"]);
                Console.Read();
            }
        }
    }
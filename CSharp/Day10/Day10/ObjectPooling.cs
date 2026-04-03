using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class StudentFactory
    {
        //Pool size for maximum objects

        static int MaxPoolSize = 3;
        static readonly Queue objPool = new Queue(MaxPoolSize);

        public Students GetStudent()
        {
            Students stdobj;
            //check from the Q collection pool. if exists, return the object else create new 
            if (Students.objcounter >= MaxPoolSize && objPool.Count > 0)
            {
                stdobj = RetriveFromPool();
            }
            else
            {
                stdobj = GetNewStudent();
            }
            return stdobj;
        }

        Students GetNewStudent()
        {
            //Create a new student object
            Students s = new Students();
            objPool.Enqueue(s);
            return s;
        }

        protected Students RetriveFromPool()
        {
            Students s1;
            //check if there are any objects in the Q collection

            if (objPool.Count > 0)
            {
                s1 = (Students)objPool.Dequeue();
                Students.objcounter--;
            }
            else
            {
                //Return a new object
                s1 = new Students();
            }
            return s1;
        }
    }
    class Students
    {
        public static int objcounter = 0;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }
        public int RollNo { get; set; }
        public Students()
        {
            ++objcounter;
        }

    }
    class ObjectPooling
    {
        static void Main()
        {
            StudentFactory stdfac = new StudentFactory();
            Students student = stdfac.GetStudent();
            Console.WriteLine("*****************");
            Console.WriteLine("First Object");

            Students student1 = stdfac.GetStudent();
            Console.WriteLine("*****************");
            Console.WriteLine("Second Object");

            Students student2 = stdfac.GetStudent();
            Console.WriteLine("*****************");
            Console.WriteLine("Third Object");

            Students student3 = stdfac.GetStudent();
            Console.WriteLine("*****************");
            Console.WriteLine("Fourth Object");

            Students student4 = stdfac.GetStudent();
            Console.WriteLine("*****************");
            Console.WriteLine("Fourth Object");
            Console.Read();
        }
    }

}

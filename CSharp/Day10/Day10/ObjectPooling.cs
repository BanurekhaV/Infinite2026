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
        //pool size for maximum objects
        static int MaxPoolSize = 3;
        static readonly Queue objPool = new Queue(MaxPoolSize);

        public Students GetStduent()
        {
            Students stdobj;
            //check the pool if object exists, if yes return the object
            if(Students.objCounter >= MaxPoolSize && objPool.Count>0)
            {
                stdobj = RetrieveFromPool();
            }
            else
            {
                stdobj = GetNewStudent();
            }
            return stdobj;
        }

        Students GetNewStudent()
        {
            //create a new students object
            Students s  = new Students();
            objPool.Enqueue(s);
            return s;
        }

         Students RetrieveFromPool()
         {
            Students s1;

            //check if the pool is having objects
            if (objPool.Count > 0)
            {
                s1 = (Students)objPool.Dequeue();
                Students.objCounter = Students.objCounter -1;
            }
            else
            {
                s1 = new Students();
            }
            return s1;
         }
    }

    class Students
    {
        public static int objCounter = 0;
        public int RollNo { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Class {  get; set; }
    
        public Students()
        {
           ++objCounter;
        }

    }
    internal class ObjectPooling
    {
        static void Main()
        {
            StudentFactory factory = new StudentFactory();
            Students stud = factory.GetStduent();
            Console.WriteLine("*******************");
            Console.WriteLine("First Object...");

            Students stud1 = factory.GetStduent();
            Console.WriteLine("*******************");
            Console.WriteLine("Second Object...");

            Students stud2 = factory.GetStduent();
            Console.WriteLine("*******************");
            Console.WriteLine("Third Object...");

            Students stud4 = factory.GetStduent();
            Console.WriteLine("*******************");
            Console.WriteLine("Fourth Object...");

            Students stud5 = factory.GetStduent();
            Console.WriteLine("*******************");
            Console.WriteLine("Fifth Object...");
            Console.Read();
        }
    }
}

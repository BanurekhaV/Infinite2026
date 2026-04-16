using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_with_Unity.Abstracts;


namespace DI_with_Unity.Concrete
{
    internal class CourseClass : ICourse
    {
        public void GetAllCourses()
        {
            Console.WriteLine("List of all courses");
        }
    }
}

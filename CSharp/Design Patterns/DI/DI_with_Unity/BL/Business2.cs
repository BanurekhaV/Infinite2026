using DI_with_Unity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_with_Unity.BL
{
    internal class Business2
    {
        ICourse _course;

        public Business2(ICourse course)
        {
            _course = course;
        }

        public void GetCourse()
        {
            _course.GetAllCourses();
        }
    }
}

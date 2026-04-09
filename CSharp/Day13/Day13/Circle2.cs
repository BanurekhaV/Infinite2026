using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public partial class Circle
    {
         partial void area(int z)
         {
            double area = 3.14 * z * z;
            Console.WriteLine("Area is : {0} ", area);
         }
    }
}

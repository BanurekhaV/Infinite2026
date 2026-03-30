using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    struct Point
    {

    public int x;
    public int y; 
        //2. parameterized constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(int x)  // empty constructors are not possible
        {
            this.x = x;
            y = 100;   // all field of the structure have to be initialized before exitting the constructor
        }

    }  
    internal class Workingwith_Structures
    {
        static void Main()
        {
            Point point = new Point();  // 1. default constructor provided by the compiler
            point.x = 1;
            point.y = 2;
            Console.WriteLine(point.x + " " + point.y);
            Point point1 = new Point(3,4);
            Console.WriteLine(point1.x + " " + point1.y);
            Point point2 = new Point(5);
            Console.WriteLine(point2.x + " " + point2.y);
            Console.WriteLine("----------------");

            Rectangle rectangle = new Rectangle(5.0,4.0);
            Console.WriteLine(rectangle.GetArea());
            Console.Read();
        }
    }

   //Interface and structures

    public interface IShape
    {
        double GetArea();
    }

    struct Rectangle : IShape
    {
        public double length;
        public double breadth;

        public Rectangle(double l, double b)
        {
            length = l;
            breadth = b;
        }

       public double GetArea()
        {
            return length * breadth;
        }
    }
}

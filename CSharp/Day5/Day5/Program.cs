using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    abstract class Shapes
    {
        //declaring an abstract method
        abstract public int Area();

        //defining non-abstract virtual method
        public virtual int Circumference()
        {
            return 0;
        }

        //defining non-abstract non-virtual method
        public void ShapeDetails()
        {
            Console.WriteLine("This is Base Shape");
        }
    }

    class Square : Shapes
    {
        int side = 0;

        //constructor
        public Square(int n)
        {
            side = n;
        }
        public override int Area()  // compulsory override of an abstract method
        {
            return side * side;
        }

        public override int Circumference()  // optional override of virtual method
        {
            return 100;
        }

        public new void ShapeDetails()
        {
            Console.WriteLine("This is Square Shape");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(5);
            Console.WriteLine("Area = " + " " + s.Area());
            s.ShapeDetails();

            Shapes shapes;
            shapes = new Square(6);
            Console.WriteLine("Area = " + " " + shapes.Area());
            shapes.ShapeDetails();
            Console.Read();
        }
    }
}

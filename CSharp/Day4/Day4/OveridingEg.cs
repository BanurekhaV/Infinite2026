using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{

    class Shape
    {
        protected float R, L, B;

        public virtual float Area()
        {
            Console.WriteLine("Area of shape is being Determined here..");
            return 3.14f * R * R;
        }

        public virtual float Circumference()
        {
            Console.WriteLine("Circumference of the shape is calculated here..");
            return 2 * 3.14f * R;
        }
    }

    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.WriteLine("Enter Length :");
            L = float.Parse(Console.ReadLine());
            Console.WriteLine("enter Breadth :");
            B = Convert.ToSingle(Console.ReadLine());
        }

        public override float Area()
        {
            GetLB();
            return L * B;
        }
        public override float Circumference()
        {
            return 2 * (L + B);
        }
    }

    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.WriteLine("Enter Radius :");
            R = float.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return 9.54f; ;
        }
        public override float Circumference()
        {
            return 5.5f;
        }
    }
    internal class OveridingEg
    {
        static void Main()
        {
            //Rectangle rectangle = new Rectangle();
            //Console.WriteLine("Area of Rectangle is {0} ",rectangle.Area());
            //Console.WriteLine("Circumference of Rectangle is {0} ", rectangle.Circumference());
            //Circle circle = new Circle();
            //Console.WriteLine("Area and Circumference of Circle is  {0} , {1} ", circle.Area() , circle.Circumference());
            //Console.WriteLine("---------------------------");
            //circle.GetRadius();
            //Console.WriteLine("Area and Circumference of Circle is  {0} , {1} ", circle.Area(), circle.Circumference());

            Shape s = new Shape();
            Console.WriteLine(s.Area());            
            
            s = new Rectangle();  //co-variance
            Console.WriteLine("The Area of rect is {0} ", s.Area());

            s = new Circle();
            Console.WriteLine("The area of circle is {0} ", s.Area());

            Console.Read();

        }
    }
}

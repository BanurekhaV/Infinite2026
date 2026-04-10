using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    public class Shape
    {
        public const float PI = 3.14f;
    }

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; }
        public double Breadth { get; }

        public Rectangle(double l, double b)
        {
            Length = l;
            Breadth = b;
        }

        public class Triangle : Shape
        {
            public double Base { get; }
            public double Height { get; }

            public Triangle(double b, double h)
            {
                Base = b;
                Height = h;
            }
        }
        public class PatternmatchingEg
        {
            static void PrintType(object obj)
            {
                switch (obj)
                {
                    case Employee e:
                        Console.WriteLine("obj is an Employee type");
                        break;
                    case int i:
                        Console.WriteLine("obj is an integer");
                        break;
                    case double d:
                        Console.WriteLine("obj is a double ");
                        break;
                    default:
                        Console.WriteLine("obj is some unknown type");
                        break;
                }
            }

            //static void LocatePoint(int x, int y)
            //{
            //    switch((x,y))
            //    {
            //        case (0, 0):
            //            Console.WriteLine("Point at Origin");
            //            break;
            //        case (0, _):
            //            Console.WriteLine("Point at Y axis");
            //            break;
            //        case (_,0):
            //            Console.WriteLine("Point at X axis");
            //        default:
            //            Console.WriteLine("some point");
            //            break;
            //    }
            //}

            static void ManyPattern()
            {
                Employee e = null;
                e = new Employee { Name = "Kamlesh" };

                switch (e)
                {
                    //constant pattern
                    case null: Console.WriteLine("It is a constant pattern"); break;
                    //type pattern
                    case Employee emp when emp.Name.StartsWith("D"):
                        Console.WriteLine("Type Pattern " + emp.Name); break;
                    //var pattern
                    case var x:
                        Console.WriteLine("Var Pattern " + x?.GetType().Name); break;
                }
            }

            public static void DisplayArea(Shape shape)
            {
                if (shape is Circle c)
                {
                    Console.WriteLine("Area of circle is : " + c.Radius * c.Radius * Shape.PI);
                }
                else if (shape is Rectangle r)
                {
                    Console.WriteLine("Area of Rectangle is :" + r.Length * r.Breadth);
                }
                else if (shape is Triangle t)
                {
                    Console.WriteLine("Area of Triangle is :" + 0.5 * t.Base * t.Height);
                }
                else
                {
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
                }
            }

            static void Main()
            {
                var emp = new Employee() { Name = "Infinite" };
                PrintType(emp);
                PrintType(45);
                PrintType(3.14);
                PrintType("Hello");

                ManyPattern();
                Console.WriteLine("-----------Pattern---------");
                Rectangle r = new Rectangle(5, 7);
                DisplayArea(r);
                Console.Read(); ;
            }

        }
    }
}
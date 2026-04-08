using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    //outer class
    public class Car
    {
        public static string typeofCar = "SUV";
        public string Brand = "Hyndai";
        public void displayCar()
        {
            Console.WriteLine("Car : Creata");
        }

        //inner class
        public class Engine
        {
            public void displayEngine()
            {
                Console.WriteLine("Engine : Diesel Engine");
               
                Car sportscar = new Car();
                Console.WriteLine("The Car type is " + Car.typeofCar); //static of outer
                Console.WriteLine("the Brand is : "+ sportscar.Brand);  // non static of outer
            }
        }
    }

    //for inheritance between outer and inner
    class Computer
    {
        public void Show()
        {
            Console.WriteLine("High Configuartion Computer..");
        }

       public class CPU
        { 
           public void Display()
            {
                Console.WriteLine("I am CPU..");
            }
        }
    }

    //inheriting outer class
    class Desktop : Computer
    {

    }

    //inheriting inner class
    class Laptop : Computer.CPU
    {

    }
    internal class NestesClassEg
    {
        static void Main()
        {
            //create object of the car/outer class
            Car regularcar = new Car();
            regularcar.displayCar();

            //inner class object
            Car.Engine dieselengine = new Car.Engine();
            dieselengine.displayEngine();

            Desktop dt = new Desktop();
            dt.Show();  // 
            Console.Read();
        }
    }
}

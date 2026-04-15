using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.FactoryImplementors;
using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory regularFactory = new RegularVehicleFactory();

            IBike regularbike = regularFactory.CreateBike();
            regularbike.GetDetails();

            ICar regularcar = regularFactory.CreateCar();
            regularcar.GetDetails();

            Console.WriteLine("--------Sports----------");

            IVehicleFactory sportsfactory = new SportsVehicleFactory();

            IBike sportsbike = sportsfactory.CreateBike();
            sportsbike.GetDetails();

            ICar sportscar = sportsfactory.CreateCar();
            sportscar.GetDetails();

            Console.Read();
        }
    }
}

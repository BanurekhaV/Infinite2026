using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.FactoryImplementors
{
    public class SportsVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportsBike();
        }

        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }
}

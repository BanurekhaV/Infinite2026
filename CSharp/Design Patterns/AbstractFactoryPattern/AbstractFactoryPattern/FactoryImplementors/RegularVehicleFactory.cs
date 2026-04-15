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
    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }
        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }
}

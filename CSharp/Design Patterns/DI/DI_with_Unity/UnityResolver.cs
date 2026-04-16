using DI_with_Unity.Abstracts;
using DI_with_Unity.BL;
using DI_with_Unity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DI_with_Unity
{
    static class UnityResolver
    {
        public static (BusinessClass bc, Business2 bc2) DIInjector()
        {
            UnityContainer uc = new UnityContainer();

            uc.RegisterType<IProducts, ProductClass>();
            uc.RegisterType<IOrders, OrderClass>();
            uc.RegisterType<ICourse, CourseClass>();

            //invoking the DI enabled methods thru dependant object
            BusinessClass bc = uc.Resolve<BusinessClass>();
            Business2 bc2 = uc.Resolve<Business2>();
            return (bc, bc2);
        }
    }
}

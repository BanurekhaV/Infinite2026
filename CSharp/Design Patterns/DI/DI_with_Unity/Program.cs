using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_with_Unity.Concrete;
using Microsoft.Practices.Unity;
using Unity;
using DI_with_Unity.Abstracts;
using DI_with_Unity.BL;

namespace DI_with_Unity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a unity container object
            UnityContainer uc = new UnityContainer();

            uc.RegisterType<IProducts,ProductClass>();
            uc.RegisterType<IOrders,OrderClass>();
            uc.RegisterType<ICourse,CourseClass>();

            //invoking the DI enabled methods thru dependant object
            BusinessClass bc = uc.Resolve<BusinessClass>();
            Business2 bc2 = uc.Resolve<Business2>();

            bc.Insert();
            bc.ShowOrders();

            bc2.GetCourse();
            Console.Read();
        }
    }
}

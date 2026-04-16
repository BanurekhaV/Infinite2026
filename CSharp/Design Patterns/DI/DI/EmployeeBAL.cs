using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class EmployeeBAL   //dependant class
    {
        private IEmployeeDAL eDAL;

        //1. we will inject the dependency class object(EmployeeDAL) into the
        //BAL class Via Constructor

        //public EmployeeBAL(IEmployeeDAL iedal)
        //{
        //    this.eDAL = iedal;
        //}


        //2. Property Injection
        //public IEmployeeDAL empDataLayer
        //{
        //    set { this.eDAL = value; }
        //    get { return this.eDAL; }
        //}

        //3. Method Injection
        public List<Employee>GetAllEmployees(IEmployeeDAL edal)
        {
            // return eDAL.SelectAllEmployees();
            // return empDataLayer.SelectAllEmployees();

            return edal.SelectAllEmployees();
        }
    }
}

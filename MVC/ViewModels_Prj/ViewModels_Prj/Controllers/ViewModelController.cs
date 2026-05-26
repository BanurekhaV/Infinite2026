using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels_Prj.Models;

namespace ViewModels_Prj.Controllers
{
    public class ViewModelController : Controller
    {
        // GET: ViewModel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmpAddDetails()
        {
            Employee emp = new Employee()
            {
                EId = 101,
                EName = "Jamuna",
                Salary = 65000,
                AddressId = 1,
            };

            Address addr = new Address()
            {
                AddressId = 1,
                DoorNo = "4 ABC Villa",
                StreetName = "GulliNo 420",
                City ="MyCity"
            };

            //create a view model object
            EmployeeAddress empAdd = new EmployeeAddress()
            {
                employee = emp,
                address = addr,
                PageTitle = "Employee Full Details"
            };
            return View(empAdd);
        }
    }
}
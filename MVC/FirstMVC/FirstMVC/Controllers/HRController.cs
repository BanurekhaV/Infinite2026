using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        //3. calling another view and passing the model object
        public ActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department() { ID = 10, DeptName = "CSE" });
            departments.Add(new Department() { ID = 11, DeptName = "AI & DS" });
            departments.Add(new Department() { ID = 12, DeptName = "ECE" });
            departments.Add(new Department() { ID = 13, DeptName = "IT" });
            return View("DepartmentList",departments);
        }

        public ActionResult DepartmentList(Department department)
        {
            return View(department);
        }

        //1. binding an object model to the view
        public ActionResult DisplayEmployee()
        {
            Employee emp = new Employee() { Id = 100, Name = "Rajesh", Age = 25 };
            return View(emp);
        }

        //2. Binding a collection model object to the view
        public ActionResult EmployeeList()
        {
            List<Employee> emplist = new List<Employee>()
            {
             new Employee{Id=1, Name="Rama", Age=17},
             new Employee{Id=2, Name="Sitha", Age=14},
             new Employee{Id=3, Name="Laxmana", Age=15},
            };
            return View(emplist);
        }

        // 4. different view name from that of the action method
        // 4.1 we can give action name selector and map it to the view of a different name
        // 4.2 We can change the name of the view to match the action name
        [ActionName("TestView")]
        public ActionResult DifferentActionname()
        {
            ViewBag.sample = "Testing Views with Different names";
          //  return View("DifferentActionname");  //4.1
          return View(); //4.2
        }
        
    }
}
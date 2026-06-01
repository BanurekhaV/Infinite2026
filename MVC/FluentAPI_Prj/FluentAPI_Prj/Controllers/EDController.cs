using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentAPI_Prj.Models;

namespace FluentAPI_Prj.Controllers
{
    public class EDController : Controller
    {
        EDContext edContext = new EDContext();
        // GET: ED
        public ActionResult Index()
        {
            return View(edContext.Employees.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee e)
        {
            edContext.Employees.Add(e);
            edContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Employee e = edContext.Employees.Find(Id);
            return View(e);
        }

        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            Employee emp = edContext.Employees.Find(e.Id);
            emp.EName = e.EName;
            emp.Salary = e.Salary;
            emp.Department = e.Department;
            edContext.SaveChanges();
            return View();
        }
    }
}
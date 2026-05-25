using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Html_Helpers_Prj.Models;

namespace Html_Helpers_Prj.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //1. strongly typed helper
        public ActionResult Strongly_Typed()
        {
            return View();
        }

        //2. Templated Helper for individual model properties
        public ActionResult Templated_Helper()
        {
            return View();
        }

        //3. Templated helper for the entire Model for edit
        public ActionResult TemplateForModel()
        {
            return View();
        }

        //4. Templated helper for Display of the Model 
        public ActionResult StudentDisplay()
        {
            Student stud = new Student()
            {
                RNo = 10,
                name = "Test",
                Address = "Chennai",
            };
            return View(stud);
        }

        //5. standard helper

        public ActionResult StandardHelper()
        {
            return View();
        }
    }

}
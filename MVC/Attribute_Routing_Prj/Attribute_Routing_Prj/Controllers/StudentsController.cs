using Attribute_Routing_Prj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Attribute_Routing_Prj.Controllers
{
    [RoutePrefix("Data")]
    public class StudentsController : Controller
    {
        static List<Student> students = new List<Student>()
        { 
            new Student(){ID = 1,Name ="priyanka" },
            new Student(){ID = 2,Name ="vanaja" },
            new Student(){ID = 3,Name ="anand" },
            new Student(){ID = 4,Name ="anu" },
        };

        [HttpGet]
        [Route]
        [Route("allStds")]
        public ActionResult GetAllStudents()
        {
            return  View(students);
        }

        [HttpGet]
        //  [Route("students/{studentid}")]
        // [Route("{studentid:int:min(1):max(3)}")]
        [Route("{studentid:int:range(1,3)}")]
        public ActionResult GetStudentByID(int studentid)
        {
            Student std = students.FirstOrDefault(s=>s.ID == studentid);
            return View(std);
        }


        [HttpGet]
        [Route("{name:alpha:maxlength(5)}")]
        public ActionResult GetStudentByName(string name)
        {
            Student std = students.FirstOrDefault(s=>s.Name == name);
            return View(std);
        }
        //attribute routing
        // [Route("students/{studentid}/courses")]
        [Route("{studentid}/courses")]
        public ActionResult GetStudentCourse(int studentid)
        {
            List<string> CourseList = new List<string>();

            if (studentid == 1)
            {
                CourseList = new List<string>() { "ASP.Net", "C#.Net", "SQL Server" };
            }
            else if (studentid == 2)
            {
                CourseList = new List<string>() { "ASP.NET MVC", "C#.Net", "ADO.Net" };
            }
            else if (studentid == 3)
            {
                CourseList = new List<string>() { "ASP.NET Web API", "C#.Net", "EF" };
            }
            else
             
                CourseList = new List<string>() {"BootStrap", "JQuery", "Angular" };
            
            ViewBag.courseList = CourseList;
            return View();
        }

        //populating second model object
        [Route("~/technical/trainers")]  // ~ is used to override a RoutePrefix
        public ActionResult GetTrainers()
        {
            List<Trainer> trainers = new List<Trainer>()
            { 
                new Trainer {TId = 101, Name = "Geetha"},
                new Trainer {TId = 101, Name = "Banurekha"},
                new Trainer {TId = 102, Name = "Williams"}
            };
            return View(trainers);
        }
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }
    }
}
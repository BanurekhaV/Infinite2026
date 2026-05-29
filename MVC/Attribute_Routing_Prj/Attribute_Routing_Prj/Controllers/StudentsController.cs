using Attribute_Routing_Prj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Attribute_Routing_Prj.Controllers
{
    [RoutePrefix("students")]
    public class StudentsController : Controller
    {
        static List<Student> students = new List<Student>()
        { 
            new Student(){ID = 1,Name ="Priyanka" },
            new Student(){ID = 2,Name ="Vanaja" },
            new Student(){ID = 3,Name ="Anand" },
            new Student(){ID = 4,Name ="Aadesh" },
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
        [Route("{name:alpha}")]
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
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }
    }
}
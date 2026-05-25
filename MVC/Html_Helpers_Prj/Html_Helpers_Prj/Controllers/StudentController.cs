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

    }
}
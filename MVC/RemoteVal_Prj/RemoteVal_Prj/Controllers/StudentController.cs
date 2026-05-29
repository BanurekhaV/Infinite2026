using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RemoteVal_Prj.Models;

namespace RemoteVal_Prj.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student student = new Student();
            return View(student);
        }

        [HttpGet]
        public JsonResult IsMailExist(string Email)
        {
            bool isExist = false;
            if(Email.Equals("xxx@gmail.com"))
            {
                  isExist = true;
            }
            return Json(!isExist, JsonRequestBehavior.AllowGet);
        }
    }
}
using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        //various types of action results
        //1. Normal method
        public string NormalMethod()
        {
            return " Hi All !!";
        }

        //2. view result
        public ViewResult ViewMethod()
        {
            return View();
        }

        //3. contentresult
        public ContentResult ContentMethod()
        {
            // return Content("Hello All .. This is Content Result", "text/plain");
            return Content("<h1 style=color:red;>Good Evening All </h1>", "text/html");
        }

        //4. empty result that does not show anything to the user
        [NonAction]
        public EmptyResult EmptyMethod()
        {
            int amt = 45000;
            float si = (amt * 3 * 2) / 100;
            return new EmptyResult();
        }

        // 5. redirect
        public ActionResult RedirectMethod()
        {
            //redirect to other action methods of the same controller
            // return RedirectToAction("ContentMethod");

            //redirect to action methods of other controllers
            return RedirectToAction("index", "home");           
        }

        //6. json result
        public JsonResult JsonMethod()
        {
            Employee employee = new Employee() 
            { Id = 1,
              Name = "Ranjani",
              Age = 30
            };
            return Json(employee,JsonRequestBehavior.AllowGet);
        }

        // testing the tempdata values sent form Data controllers Index method
        public ActionResult Test_Other_Controller_Request()
        {
            TempData.Keep();
            // return View(TempData["stores"]); 
            return RedirectToAction("Contact", "Home");
        }
    }
}
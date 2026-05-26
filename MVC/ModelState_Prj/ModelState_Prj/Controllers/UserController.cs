using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using ModelState_Prj.Models;

namespace ModelState_Prj.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        //1. If Validation Succeeds
        public ActionResult UserStatus()
        {
            ViewBag.status = "Validation Successful";
            return View();
        }

        //2. Add a User
        [HttpGet]
        public ActionResult AddUser()
        {
            User user = new User();
            return View(user);

        }

        [HttpPost]
        public ActionResult AddUser(User user)
        {
            if(string.IsNullOrEmpty(user.Lname))
            {
                ModelState.AddModelError("Lname", "Last Name is a must..");
            }
            if(user.age <21 || user.age >45)
            {
                ModelState.AddModelError("age", "Allowed age only between 21 and 45");
            }

            if (!ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                TempData["lastname"] = user.Lname;
                TempData["age"] = user.age;
                TempData.Keep();
                return RedirectToAction("UserStatus");
            }
            
        }

    }
}
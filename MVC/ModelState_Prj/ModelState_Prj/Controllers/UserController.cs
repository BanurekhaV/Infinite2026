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
    }
}
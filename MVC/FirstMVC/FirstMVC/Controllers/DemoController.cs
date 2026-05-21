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

    }
}
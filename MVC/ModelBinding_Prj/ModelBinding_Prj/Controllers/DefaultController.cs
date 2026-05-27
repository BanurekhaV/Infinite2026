using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBinding_Prj.Models;
using ModelBinding_Prj.CustomBindings;

namespace ModelBinding_Prj.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index([ModelBinder(typeof(CustomBinder))]CustomModel cm)
        {
            ViewBag.SplTitle = cm.Title;
            ViewBag.dt = cm.Date;
            return View(cm);
        }

        //bundling scripts
        public ActionResult BundlingMethod()
        {
            return View();
        }
    }
}
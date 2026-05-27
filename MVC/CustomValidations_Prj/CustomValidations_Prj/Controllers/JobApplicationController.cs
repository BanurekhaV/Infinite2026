using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomValidations_Prj.Models;

namespace CustomValidations_Prj.Controllers
{
    public class JobApplicationController : Controller
    {
        // GET: JobApplication
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(JobApplication JA)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Result = "Application Form Submitted Successfully";
            }
            else
            {
                ViewBag.Result = "Invalid Entries Found, Check and Resubmit..";
            }
            return View();
        }
    }
}
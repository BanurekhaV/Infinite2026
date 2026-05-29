using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filters_Prj.CustomFilters;

namespace Filters_Prj.Controllers
{
    public class CustomFilterController : Controller
    {
        // GET: CustomFilter
        [TrackExecutions]
        public string Index()
        {
            return "Index Action Method invoked";
        }

        [TrackExecutions]
        public string Welcome()
        {
            throw new Exception("Exception Occurred");
        }

        //[Authorize]
        public ActionResult SafetyMethod()
        {
            return View();
        }
    }
}
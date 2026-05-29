using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters_Prj.Controllers
{
    //for different types of errors, different error view pages
    [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivideByZero")]
    [HandleError(ExceptionType = typeof(NullReferenceException), View = "NullReference")]
    //[HandleError]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            throw new Exception("Something Went Wrong..");
           // return View();
           
        }

        public ActionResult TestNullReference()
        {
            throw new NullReferenceException();
        }

        public ActionResult TestDivideByZero()
        {
            throw new DivideByZeroException();
        }
    }
}
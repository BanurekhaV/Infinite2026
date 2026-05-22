using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        // 1. Passing an object to the view that will be used as a model
        public ActionResult Index()
        {
            ViewBag.Mydata = "Flowers Collection";
            List<string> flowers = new List<string>()
            {
                "Roses","Lillies","Jasmines","Marigolds"
            };
            // return View(flowers);

            // 4.3 trying to access the tempdata values in the 3rd request
            //List<string> stlist = TempData["stores"] as List<string>;
            //return View(stlist);
            TempData.Keep();
            return RedirectToAction("Test_Other_Controller_Request", "Demo");
        }

        // 2. checking if viewbag can pass the information/data to further request
        public ActionResult TestDataTransfer()
        {
            ViewBag.Data1 = "Data one";
            ViewData["vd"] = "Some Data here.";
            return View(); //viewbag data is passed to the current view
          // return RedirectToAction("Index");
        }

        // 3. Passing data thru viewbag and viewdata
        public ActionResult OfficeRules()
        {
            List<string> rules = new List<string>()
            {
                "Be on Time","Carry your ID card","Avoid Casuals","Complete work as per deadlines"
            };
            // 3.1 transfer data using viewbag
            ViewBag.Offrules = rules;

            // 3.2 transfer data using viewdata
            ViewData["followrules"] = rules;

            return View();
        }

        // 4. with tempdata
        public ActionResult FirstTempRequest()
        {
            List<string> stationeries = new List<string>()
            { "Pens", "Pencils","Erasers","Markers","Notebooks"};

            TempData["stores"] = stationeries;

            // 4.1 using the tempdata in the current view
          //  return View();

            // 4.2 using tempdata for further request
            return RedirectToAction("SecondTempRequest");
        }

        public ActionResult SecondTempRequest()
        {
            List<string> stnlist;
            stnlist = TempData["stores"] as List<string>;
            // return View(stnlist);   works well (2nd request)
            return RedirectToAction("Index");
        }
    }
}
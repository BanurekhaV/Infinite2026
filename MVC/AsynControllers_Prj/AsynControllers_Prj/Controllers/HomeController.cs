using AsynControllers_Prj.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AsynControllers_Prj.Controllers
{
    
    public class HomeController : Controller
    {
        private InfiniteDBEntities1 db = new InfiniteDBEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public async Task<ActionResult> TestTask()
        {
            return View(await db.tblDepartments.ToListAsync());
        }
    }
}
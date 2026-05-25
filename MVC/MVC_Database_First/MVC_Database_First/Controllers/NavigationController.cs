using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Database_First.Models;

namespace MVC_Database_First.Controllers
{
    public class NavigationController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        // GET: Navigation
        public ActionResult Index()
        {
            //dynamic mymodel = new ExpandoObject();
            //mymodel.orders = db.Orders.ToList();
            //mymodel.cust = db.Customers.ToList();

            //working with multiple models
            return View(db.Orders.ToList());
        }
    }
}
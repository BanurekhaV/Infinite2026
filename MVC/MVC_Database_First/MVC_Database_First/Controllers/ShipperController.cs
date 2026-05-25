using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using MVC_Database_First.Models;

namespace MVC_Database_First.Controllers
{
    public class ShipperController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Shipper
        public ActionResult Index()
        {
            return View(db.Shippers.ToList());
        }

        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost,ActionName("Create")]
        // public ActionResult Create(FormCollection frm)
        //{
        //1. adding shipper record thru forms collection
        //Shipper s = new Shipper();
        //s.ShipperID = Convert.ToInt32(frm["ShipperID"]);
        //s.CompanyName = frm["CompanyName"].ToString();
        //s.Phone = frm["Phone"].ToString();

        //db.Shippers.Add(s);
        //db.SaveChanges();
        //return RedirectToAction("Index");


        //2. passing data from view to controller using parameter collections
        //use the same name as that of the class/entity
        //public ActionResult Create(string Companyname, string phone)
        //{
        //    //Shipper shipper = new Shipper();
        //    //shipper.CompanyName = Companyname;
        //    //shipper.Phone = phone;
        //    //db.Shippers.Add(shipper);
        //    //db.SaveChanges();
        //    //return RedirectToAction("Index");
        //}

        //3. passing data from view to controller using request object
        public ActionResult CreatePost()
        {
            Shipper shipper = new Shipper();
            shipper.CompanyName = Request["CompanyName"].ToString();
            shipper.Phone = Request["Phone"].ToString() ;
            db.Shippers.Add(shipper);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //4. stored procedure calling
        public ActionResult Sp_With_Input()
        {
            return View(db.CustOrdersOrders("alfki"));
        }
    }
}
using MVC_Database_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Database_First.Controllers
{
    public class RegionController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Region
        public ActionResult Index()
        {
            return View(db.Regions.ToList());
        }

        [HttpGet]
        // 1. Adding a new Region
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Region region)
        {
            db.Regions.Add(region);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //delete a region
        public ActionResult Delete(int id)
        {
            Region region = db.Regions.Find(id);
            return View(region);
        }

       [HttpPost, ActionName("Delete")]
       public ActionResult DeleteRegion(int id)
        {
            Region r = db.Regions.Find(id);
            db.Regions.Remove(r);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //edit a region
        [HttpGet]
        public ActionResult Update(int id)
        {
            Region region = db.Regions.Find(id);
            return View(region);
        }

        [HttpPost]
        public ActionResult Update(Region r)
        {
            Region reg = db.Regions.Find(r.RegionID);
            reg.RegionID = r.RegionID;
            reg.RegionDescription = r.RegionDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //details view of the region
        public ActionResult Details(int id)
        {
            Region r = db.Regions.Find(id);
            return View(r);
        }
    }
}
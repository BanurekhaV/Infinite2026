using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Database_First.Models;

namespace MVC_Database_First.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Category

        //2. action method with scaffolded view using the template
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        // 1. action method without scaffolded view
        public ActionResult GetCategoryDetails()
        {
            List<Category> categories = db.Categories.ToList();
            return View(categories);
        }

        //3. sorting the category by name
        public ActionResult GetCategoryByName()
        {
            List<string> sortedcatnames = (from c in db.Categories
                                           orderby c.CategoryName
                                           select c.CategoryName).ToList();
            return View(sortedcatnames);
        }
    }
}

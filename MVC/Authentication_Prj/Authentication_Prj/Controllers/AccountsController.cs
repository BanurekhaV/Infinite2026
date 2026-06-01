using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Authentication_Prj.Models;

namespace Authentication_Prj.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User umodel)
        {
            using(Infinite_MVCSecurityEntities1 context = new Infinite_MVCSecurityEntities1())
            {
                bool IsValidUser = context.Users.Any(user => user.UserName.ToLower()==
                umodel.UserName.ToLower() && user.UserPassword == umodel.UserPassword);

                if (IsValidUser)
                {
                    FormsAuthentication.SetAuthCookie(umodel.UserName,false);
                    return RedirectToAction("Index", "Employees");
                }

                ModelState.AddModelError("", "Invalid UserName or Password");
                return View();
            }
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User umodel)
        {
            using (Infinite_MVCSecurityEntities1 context = new Infinite_MVCSecurityEntities1())
            {
                context.Users.Add(umodel);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}
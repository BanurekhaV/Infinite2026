using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Sample_MVCPrj.Models;
using System.Diagnostics;

namespace Sample_MVCPrj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult SubmitForm(User user)
        //{
        //    if(user !=null)
        //    {
        //        if(ModelState.IsValid)
        //        {
        //            ViewBag.Message = $"User Created UserName : {user.UserName}" + 
        //                $"User Email :{user.UserEmail}";
        //            ModelState.Clear();  // optional
        //            return View("Index");
        //        }                
        //    }
        //    return View("Index", user);
        //}

        public IActionResult SubmitForm(IFormCollection form)
        {
            //use keys to get the collection of form keys
            var keys = form.Keys;

            //check if a key exists in the form and try getting the values of the key
            if(form.ContainsKey("UserName") && form.ContainsKey("UserEmail"))
            {
               if(form.TryGetValue("UserName", out StringValues userName) &&
                    form.TryGetValue("UserEmail", out StringValues userEmail))
               {
                    ViewBag.Message = $"User Created UserName:{userName}"  +
                        $" User Email : {userEmail}";
               }
                else
                {
                    ViewBag.Message = "User Name or Email not found in the Form";
                }
            }
            else
            {
                ViewBag.Message = "Form does not contain UserName and UserEmail Keys";
            }
            return View("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

       


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

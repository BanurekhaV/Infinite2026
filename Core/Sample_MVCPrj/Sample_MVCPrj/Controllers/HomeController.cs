using Microsoft.AspNetCore.Mvc;
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
        public IActionResult SubmitForm(User user)
        {
            if(user !=null)
            {
                if(ModelState.IsValid)
                {
                    ViewBag.Message = $"User Created UserName : {user.UserName}" + 
                        $"User Email :{user.UserEmail}";
                    ModelState.Clear();  // optional
                    return View("Index");
                }                
            }
            return View("Index", user);
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

using CustomValidation_Client_Prj.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomValidation_Client_Prj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //action methods to test client validations

        public IActionResult Register()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public IActionResult Register(UserModel user)
        {
            if(!ModelState.IsValid)
            {
                return View(user);  // server side validation
            }

            //if valid, procedd to save the data to a database in general
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
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

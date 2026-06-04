using CustomModelBinding.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomModelBinding.Controllers
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

        [HttpGet]
        public IActionResult GetIds([ModelBinder(typeof(CommaSeparatedModelBinder))]List<int> Id)
        {
            return Ok(Id);
        }

        [HttpGet]
        public IActionResult GetDetails([ModelBinder(typeof(DateRangeModelBinder))] DateRange range)
        {            
            return Ok($"From {range.StartDate} to {range.EndDate}");
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

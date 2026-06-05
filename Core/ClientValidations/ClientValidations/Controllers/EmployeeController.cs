using ClientValidations.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientValidations.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return Content("Valid");
        }
    }
}

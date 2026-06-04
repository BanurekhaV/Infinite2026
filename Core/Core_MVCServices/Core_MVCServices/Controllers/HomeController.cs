using Microsoft.AspNetCore.Mvc;

namespace Core_MVCServices.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is the index action from Home";
        }
    }
}

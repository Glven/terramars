using Microsoft.AspNetCore.Mvc;

namespace terramars.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Terramars.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

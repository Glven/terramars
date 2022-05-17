using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TerraMars.Controllers
{
    public class TerraMarsController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Calculate()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Catalog()
		{
            return View();
		}
        [HttpGet]
        public async Task<IActionResult> News()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Reviews()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Employees()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Offices()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Favorites()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Cart()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Signin()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

    }
}

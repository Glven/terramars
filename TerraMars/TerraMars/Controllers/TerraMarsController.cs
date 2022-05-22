using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TerraMars.Models.Interfaces;
using TerraMars.Data;
using System.Linq;
using TerraMars.Models;
using System;
using TerraMars.Data.Entities;

namespace TerraMars.Controllers
{
    public class TerraMarsController : Controller
    {
        private readonly IFeedback _feedbackManager;
        private readonly IUser _userManager;
        public TerraMarsController(IFeedback feedbackManager, IUser userManager)
        {
            _feedbackManager = feedbackManager;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> SameFeedback()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string guestName, string guestPhone, string guestMail, string guestMessage)
        {
            var db = new TerramarsContext();
            var feedback = db.Feedbacks.FirstOrDefault(f => f.Name == guestName || f.Phone == guestPhone || f.Mail == guestMail);
            if(feedback != null)
            {
                return RedirectToAction("SameFeedback");
            }
            else
            {
                await _feedbackManager.CreateFeedback(guestName, guestPhone, guestMail, guestMessage);
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Calculate()
        {
            var db = new TerramarsContext();
            var service = db.Services.ToList();
            var model = new AllModels() { Services = service };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Catalog()
		{
            return View();
		}
        [HttpGet]
        public async Task<IActionResult> News()
        {
            var db = new TerramarsContext();
            var news = db.News.ToList();
            var model = new AllModels { News = news };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Reviews()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Employees()
        {
            var db = new TerramarsContext();
            var employee = db.Employees.ToList();
            var model = new AllModels() { Employees = employee };
            return View(model);
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
        public async Task<IActionResult> SameUser()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Signin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signin(string lastname, string name, string secondname, DateTime year, string sex, string mail, string username, string phone, string password)
        {
            var db = new TerramarsContext();
            var user = db.Users.FirstOrDefault(u => (u.Lastname == lastname && u.Name == name && u.Secondname == secondname) || u.Mail == mail || u.Phone == phone);
            if(user != null)
            {
                return RedirectToAction("SameUser");
            }
            else
            {
                await _userManager.CreateUser(lastname, name, secondname, year, sex, mail, username, phone, password);
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

    }
}

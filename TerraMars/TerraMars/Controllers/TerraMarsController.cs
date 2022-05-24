using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TerraMars.Models.Interfaces;
using TerraMars.Data;
using System.Linq;
using TerraMars.Models;
using System;
using TerraMars.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace TerraMars.Controllers
{
    public class TerraMarsController : Controller
    {
        private readonly IFeedback _feedbackManager;
        private readonly IUser _userManager;
        private readonly IFavorite _favManager;
        private readonly ICart _cartManager;
        private readonly ILogin _loginManager;
        private readonly IReview _reviewManager;
        private readonly ICompleted _completedManager;
        private readonly IRegion _regionManager;
        public TerraMarsController(IFeedback feedbackManager, IUser userManager, IFavorite favManager, ICart cartManager, ILogin loginManager, IReview reviewManager, ICompleted completedManager, IRegion regionManager)
        {
            _feedbackManager = feedbackManager;
            _userManager = userManager;
            _favManager = favManager;
            _cartManager = cartManager;
            _loginManager = loginManager;
            _reviewManager = reviewManager;
            _completedManager = completedManager;
            _regionManager = regionManager;
        }
        [HttpGet]
        public async Task<IActionResult> NullUser()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> NotFoundUser()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> SameFeedback()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> SameReview()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> SameCart()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var db = new TerramarsContext();
            var claims = HttpContext.User.Claims;
            string userName = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            string idUser = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            Guid UserId = new Guid();
            if(idUser != null)
            {
                UserId = Guid.Parse(idUser);
            }
            var user = db.Users.FirstOrDefault(u => u.Id == UserId);
            var completed = db.Completeds.ToList();
            var model = new AllModels { user = user, Completeds = completed };
            return View(model);
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
            var claims = HttpContext.User.Claims;
            string userName = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            string idUser = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            Guid UserId = new Guid();
            if (idUser != null)
            {
                UserId = Guid.Parse(idUser);
            }
            var user = db.Users.FirstOrDefault(u => u.Id == UserId);
            var model = new AllModels() { Services = service, user = user };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Catalog()
		{
            var db = new TerramarsContext();
            var regions = db.Regions.Include(s => s.Services).ToList();
            var services = db.Services.ToList();
            var claims = HttpContext.User.Claims;
            string userName = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            string idUser = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            Guid UserId = new Guid();
            if (idUser != null)
            {
                UserId = Guid.Parse(idUser);
            }
            var user = db.Users.FirstOrDefault(u => u.Id == UserId);
            var model = new AllModels { Services = services, Regions = regions, user = user };
            return View(model);
		}
        [HttpGet]
        public async Task<IActionResult> News()
        {
            var db = new TerramarsContext();
            var news = db.News.ToList();
            var claims = HttpContext.User.Claims;
            string userName = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            string idUser = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            Guid UserId = new Guid();
            if (idUser != null)
            {
                UserId = Guid.Parse(idUser);
            }
            var user = db.Users.FirstOrDefault(u => u.Id == UserId);
            var model = new AllModels { News = news, user = user };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Reviews()
        {
            var db = new TerramarsContext();
            var users = db.Users.ToList();
            var reviews = db.Reviews.ToList();
            var claims = HttpContext.User.Claims;
            string userName = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            string idUser = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            Guid UserId = new Guid();
            if (idUser != null)
            {
                UserId = Guid.Parse(idUser);
            }
            var user = db.Users.FirstOrDefault(u => u.Id == UserId);
            var model = new AllModels { Reviews = reviews, Users = users, user = user };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> createReview(int reviewGrade, string reviewComment)
        {
            var db = new TerramarsContext();
            var claims = HttpContext.User.Claims;
            string userName = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            string idUser = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            if(idUser == null)
            {
                return RedirectToAction("NullUser");
            }
            Guid userId = Guid.Parse(idUser);
            var review = db.Reviews.FirstOrDefault(r => r.User.Id == userId);
            if(review != null)
            {
                return RedirectToAction("SameReview");
            }
            else
            {
                await _reviewManager.CreateReview(userId, reviewGrade, reviewComment);
                return RedirectToAction("Reviews");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Employees()
        {
            var db = new TerramarsContext();
            var employee = db.Employees.ToList();
            var claims = HttpContext.User.Claims;
            string userName = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            string idUser = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            Guid UserId = new Guid();
            if (idUser != null)
            {
                UserId = Guid.Parse(idUser);
            }
            var user = db.Users.FirstOrDefault(u => u.Id == UserId);
            var model = new AllModels() { Employees = employee, user = user };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Offices()
        {
            var db = new TerramarsContext();
            var offices = db.Offices.Include(s => s.Schedules).ToList();
            var schedules = db.Schedules.ToList();
            var claims = HttpContext.User.Claims;
            string userName = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            string idUser = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            Guid UserId = new Guid();
            if (idUser != null)
            {
                UserId = Guid.Parse(idUser);
            }
            var user = db.Users.FirstOrDefault(u => u.Id == UserId);
            var model = new AllModels { Offices = offices, Schedules = schedules, user = user };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> SameFav()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Favorites()
        {
            var db = new TerramarsContext();
            var regions = db.Regions.Include(s => s.Services).ToList();
            var favs = db.Favorites.ToList();
            var claims = HttpContext.User.Claims;
            string userName = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            string idUser = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            Guid UserId = new Guid();
            if (idUser != null)
            {
                UserId = Guid.Parse(idUser);
            }
            var user = db.Users.FirstOrDefault(u => u.Id == UserId);
            var model = new AllModels { Regions = regions, Favorites = favs, user = user };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> createFav(Guid Id)
        {
            var db = new TerramarsContext();
            var fav = db.Favorites.FirstOrDefault(f => f.Region.Id == Id);
            if(fav != null)
            {
                return RedirectToAction("SameFav");
            }
            else
            {
                await _favManager.CreateFav(Id);
                return RedirectToAction("Favorites");
            }
        }
        [HttpGet]
        public async Task<IActionResult> deleteFav(Guid Id)
        {
            await _favManager.DeleteFav(Id);
            return RedirectToAction("Favorites");
        }
        [HttpGet]
        public async Task<IActionResult> Cart()
        {
            var db = new TerramarsContext();
            var regions = db.Regions.Include(s => s.Services).ToList();
            var carts = db.Carts.ToList();
            var claims = HttpContext.User.Claims;
            string userName = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            string idUser = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            Guid UserId = new Guid();
            if (idUser != null)
            {
                UserId = Guid.Parse(idUser);
            }
            var user = db.Users.FirstOrDefault(u => u.Id == UserId);
            var model = new AllModels { Regions = regions, Carts = carts, user = user };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> createCart(Guid Id)
        {
            var db = new TerramarsContext();
            var cart = db.Carts.FirstOrDefault(c => c.Region.Id == Id);
            if (cart != null)
            {
                return RedirectToAction("SameCart");
            }
            else
            {
                await _cartManager.CreateCart(Id);
                return RedirectToAction("Cart");
            }
        }
        [HttpGet]
        public async Task<IActionResult> deleteCart(Guid Id)
        {
            await _cartManager.DeleteCart(Id);
            return RedirectToAction("Cart");
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
                IEnumerable<User> users = await _userManager.GetAll();
                user = users.FirstOrDefault(u => u.Lastname == lastname && u.Name == name);
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, $"{lastname} {name}"),
                    new Claim("Id", user.Id.ToString())
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Login(string userLogin, string userPassword)
        {
            var user = _loginManager.userReturn(userLogin, userPassword);
            if(user == null)
            {
                return RedirectToAction("NotFoundUser");
            }
            var claims = new List<Claim>()
            {
                new Claim("Id", user.Id.ToString()),
                new Claim(ClaimTypes.Name, $"{user.Lastname} {user.Name}"),
            };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Buy()
        {
            var db = new TerramarsContext();
            var carts = db.Carts.Include(c => c.Region).ToList();
            foreach(var cart in carts)
            {
                await _completedManager.CreateCompleted(cart.Region.Photo, cart.Region.Name, cart.Region.Square, cart.Region.Price);
                await _regionManager.DeleteRegion(cart.Region.Id);
            }
            return RedirectToAction("Index");
        }

    }
}

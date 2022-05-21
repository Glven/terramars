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
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
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

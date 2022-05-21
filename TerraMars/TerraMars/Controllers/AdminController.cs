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
    public class AdminController : Controller
    {
        private readonly IEmployee _employeeManager;
        private readonly IService _serviceManager;
        private readonly INew _newManager;
        private readonly IFeedback _feedbackManager;
        public AdminController(IEmployee employeeManager, IService serviceManager, INew newManager, IFeedback feedbackManager)
        {
            _employeeManager = employeeManager;
            _serviceManager = serviceManager;
            _newManager = newManager;
            _feedbackManager = feedbackManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> adminUser()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> adminCatalog()
        {
            return View();
        }


        // начало действий с услугами
        [HttpGet]
        public async Task<IActionResult> SameService()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> NullService()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> adminServices()
        {
            var db = new TerramarsContext();
            var service = db.Services.ToList();
            var model = new AllModels() { Services = service };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> deleteService(Guid Id)
        {
            await _serviceManager.DeleleService(Id);
            return RedirectToAction("adminServices");
        }
        [HttpGet]
        public async Task<IActionResult> editService(Guid Id)
        {
            var db = new TerramarsContext();
            var service = db.Services.FirstOrDefault(s => s.Id == Id);
            return View(service);
        }
        [HttpPost]
        public async Task<IActionResult> createService(string serviceName, uint servicePrice)
        {
            var db = new TerramarsContext();
            var service = db.Services.FirstOrDefault(s => s.Title == serviceName);
            if(service != null)
            {
                return RedirectToAction("SameService");
            }
            else
            {
                await _serviceManager.CreateService(serviceName, servicePrice);
                return RedirectToAction("adminServices");
            }
        }
        [HttpPost]
        public async Task<IActionResult> editService(Service service)
        {
            if(service.Id != null && service.Title != null && service.Price != 0)
            {
                await _serviceManager.EditService(service);
                return RedirectToAction("adminServices");
            }
            else
            {
                return RedirectToAction("NullService");
            }
        }
        // конец действий с услугами


        // начало действий с новостями
        [HttpGet]
        public async Task<IActionResult> SameNew()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> NullNew()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> adminNews()
        {
            var db = new TerramarsContext();
            var news = db.News.ToList();
            var model = new AllModels { News = news };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> deleteNew(Guid Id)
        {
            await _newManager.DeleteNew(Id);
            return RedirectToAction("adminNews");
        }
        [HttpGet]
        public async Task<IActionResult> editNew(Guid Id)
        {
            var db = new TerramarsContext();
            var news = db.News.FirstOrDefault(n => n.Id == Id);
            return View(news);
        }
        [HttpGet]
        public async Task<IActionResult> detailsNew(Guid Id)
        {
            var db = new TerramarsContext();
            var news = db.News.FirstOrDefault(n => n.Id == Id);
            return View(news);
        }
        [HttpPost]
        public async Task<IActionResult> editNew(New News)
        {
            if (News.Photo != null && News.Title != null && News.Content != null)
            {
                await _newManager.EditNew(News);
            }
            else
            {
                return RedirectToAction("NullNew");
            }
            return RedirectToAction("adminNews");
        }
        [HttpPost]
        public async Task<IActionResult> createNew(string newsPhoto, string newsTitle, string newsContent)
        {
            var db = new TerramarsContext();
            var news = db.News.FirstOrDefault(n => n.Title == newsTitle || n.Content == newsContent);
            if(news != null)
            {
                return RedirectToAction("SameNew");
            }
            else
            {
                await _newManager.CreateNew(newsPhoto, newsTitle, newsContent);
                return RedirectToAction("adminNews");
            }
        }
        // конец действий с новостями
        

        [HttpGet]
        public async Task<IActionResult> adminReviews()
        {
            return View();
        }


        // начало действий с заявками
        [HttpGet]
        public async Task<IActionResult> adminFeedbacks()
        {
            var db = new TerramarsContext();
            var feebacks = db.Feedbacks.ToList();
            var model = new AllModels { Feedbacks = feebacks };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> detailsFeedback(Guid Id)
        {
            var db = new TerramarsContext();
            var feedback = db.Feedbacks.FirstOrDefault(f => f.Id == Id);
            return View(feedback);
        }
        [HttpGet]
        public async Task<IActionResult> deleteFeedback(Guid Id)
        {
            await _feedbackManager.DeleteFeedback(Id);
            return RedirectToAction("adminFeedbacks");
        }
        // конец действий с заявками



        // начало действий с сотрудниками
        [HttpGet]
        public async Task<IActionResult> NullEmployee()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> SameEmployee()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> adminEmployees()
        {
            var db = new TerramarsContext();
            var employee = db.Employees.ToList();
            var model = new AllModels() { Employees = employee };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> createEmployee(string employeePhoto, string employeeName, string employeePost, ushort employeeExperience)
        {
            var db = new TerramarsContext();
            var employee = db.Employees.FirstOrDefault(e => e.Fullname == employeeName);
            if(employee != null)
            {
                return RedirectToAction("SameEmployee");
            }
            else
            {
                await _employeeManager.CreateEmployee(employeePhoto, employeeName, employeePost, employeeExperience);
                return RedirectToAction("adminEmployees");
            }
        }
        [HttpGet]
        public async Task<IActionResult> deleteEmployee(Guid Id)
        {
            await _employeeManager.DeleteEmployee(Id);
            return RedirectToAction("adminEmployees");
        }
        [HttpGet]
        public async Task<IActionResult> editEmployee(Guid Id)
        {
            var db = new TerramarsContext();
            var employee = db.Employees.FirstOrDefault(e => e.Id == Id);
            return View(employee);
        }
        [HttpPost]
        public async Task<IActionResult> editEmployee(Employee employee)
        {
            if(employee.Photo != null && employee.Fullname != null && employee.Post != null && employee.Experience != 0)
            {
                await _employeeManager.EditEmployee(employee);
                return RedirectToAction("adminEmployees");
            }
            else
            {
                return RedirectToAction("NullEmployee");
            }
        }
        // конец действий с сотрудниками


        [HttpGet]
        public async Task<IActionResult> adminOffices()
        {
            return View();
        }
    }
}

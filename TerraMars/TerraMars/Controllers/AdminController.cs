using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TerraMars.Models.Interfaces;
using TerraMars.Data;
using System.Linq;
using TerraMars.Models;
using System;
using TerraMars.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace TerraMars.Controllers
{
    public class AdminController : Controller
    {
        private readonly IEmployee _employeeManager;
        private readonly IService _serviceManager;
        private readonly INew _newManager;
        private readonly IFeedback _feedbackManager;
        private readonly IUser _userManager;
        private readonly IRegion _regionManager;
        private readonly ISchedule _scheduleManager;
        private readonly IOffice _officeManager;
        public AdminController(IEmployee employeeManager, IService serviceManager, INew newManager, IFeedback feedbackManager, IUser userManager, IRegion regionManager, ISchedule scheduleManager, IOffice officeManager)
        {
            _employeeManager = employeeManager;
            _serviceManager = serviceManager;
            _newManager = newManager;
            _feedbackManager = feedbackManager;
            _userManager = userManager;
            _regionManager = regionManager;
            _scheduleManager = scheduleManager;
            _officeManager = officeManager;
        }

        [HttpGet]
        public async Task<IActionResult> Null()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }


        // начало действий с пользователями
        [HttpGet]
        public async Task<IActionResult> adminUser()
        {
            var db = new TerramarsContext();
            var users = db.Users.ToList();
            var model = new AllModels { Users = users };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> deleteUser(Guid Id)
        {
            await _userManager.DeleteUser(Id);
            return RedirectToAction("adminUser");
        }
        // конец действий с пользователями


        // начало действий с каталогом(регионами) многие ко многим
        [HttpGet]
        public async Task<IActionResult> SameRegion()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> adminCatalog()
        {
            var db = new TerramarsContext();
            var regions = db.Regions.Include(s => s.Services).ToList();
            var services = db.Services.ToList();
            var model = new AllModels { Regions = regions, Services = services };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> detailsRegion(Guid Id)
        {
            var db = new TerramarsContext();
            var region = db.Regions.Include(s => s.Services).FirstOrDefault(r => r.Id == Id);
            return View(region);
        }
        [HttpGet]
        public async Task<IActionResult> deleteRegion(Guid Id)
        {
            await _regionManager.DeleteRegion(Id);
            return RedirectToAction("adminCatalog");
        }
        [HttpGet]
        public async Task<IActionResult> editRegion(Guid Id)
        {
            var db = new TerramarsContext();
            var region = db.Regions.Include(s => s.Services).FirstOrDefault(r => r.Id == Id);
            ViewBag.Services = db.Services.ToList();
            return View(region);
        }
        [HttpPost]
        public async Task<IActionResult> editRegion(Region region, Guid[] ServiceId)
        {
            if (region.Photo != null && region.Name != null && region.Square != 0 && region.Price != 0)
            {
                await _regionManager.EditRegion(region, ServiceId);
                return RedirectToAction("adminCatalog");
            }
            else
            {
                return RedirectToAction("Null");
            }
        }
        [HttpPost]
        public async Task<IActionResult> createCatalog(string regionPhoto, string regionName, ushort regionSquare, uint regionPrice, Guid[] ServiceId)
        {
            var db = new TerramarsContext();
            var region = db.Regions.FirstOrDefault(r => r.Photo == regionPhoto || r.Name == regionName);
            if(region != null)
            {
                return RedirectToAction("SameRegion");
            }
            else
            {
                await _regionManager.CreateRegion(regionPhoto, regionName, regionSquare, regionPrice, ServiceId);
                return RedirectToAction("adminCatalog");
            }
        }
        // конец действий с каталогом


        // начало действий с услугами
        [HttpGet]
        public async Task<IActionResult> SameService()
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
                return RedirectToAction("Null");
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
                return RedirectToAction("Null");
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
            var employee = db.Employees.FirstOrDefault(e => e.Photo == employeePhoto || e.Fullname == employeeName);
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
                return RedirectToAction("Null");
            }
        }
        // конец действий с сотрудниками



        // начало действий с офисами (связь многие ко многим)
        [HttpGet]
        public async Task<IActionResult> SameSchedule()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> SameOffice()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> OfficeError()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> adminOffices()
        {
            var db = new TerramarsContext();
            var offices = db.Offices.Include(o => o.Schedules).ToList();
            var schedules = db.Schedules.ToList();
            var model = new AllModels { Offices = offices, Schedules = schedules };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> deleteSchedule(Guid Id)
        {
            await _scheduleManager.DeleteSchedule(Id);
            return RedirectToAction("adminOffices");
        }
        [HttpGet]
        public async Task<IActionResult> editSchedule(Guid Id)
        {
            var db = new TerramarsContext();
            var schedule = db.Schedules.FirstOrDefault(s => s.Id == Id);
            return View(schedule);
        }
        [HttpGet]
        public async Task<IActionResult> detailsOffice(Guid Id)
        {
            var db = new TerramarsContext();
            var office = db.Offices.Include(s => s.Schedules).FirstOrDefault(o => o.Id == Id);
            return View(office);
        }
        [HttpGet]
        public async Task<IActionResult> editOffice(Guid Id)
        {
            var db =new TerramarsContext();
            var office = db.Offices.Include(s => s.Schedules).FirstOrDefault(o => o.Id == Id);
            ViewBag.Schedules = db.Schedules.ToList();
            return View(office);
        }
        [HttpGet]
        public async Task<IActionResult> deleteOffice(Guid Id)
        {
            await _officeManager.DeleteOffice(Id);
            return RedirectToAction("adminOffices");
        }
        [HttpPost]
        public async Task<IActionResult> editOffice(Office office, Guid[] ScheduleId)
        {
            if (office.Address != null && office.Phone != null)
            {
                await _officeManager.EditOffice(office, ScheduleId);
                return RedirectToAction("adminOffices");
            }
            else
            {
                return RedirectToAction("Null");
            }
        }
        [HttpPost]
        public async Task<IActionResult> createOffice(string officeAddress, string officeDescription, string officePhone, Guid[] ScheduleId)
        {
            if(ScheduleId.Length == 0)
            {
                return RedirectToAction("OfficeError");
            }
            var db = new TerramarsContext();
            var office = db.Offices.FirstOrDefault(o => o.Address == officeAddress || o.Phone == officePhone);
            if (office != null)
            {
                return RedirectToAction("SameOffice");
            }
            else
            {
                await _officeManager.CreateOffice(officeAddress, officeDescription, officePhone, ScheduleId);
                return RedirectToAction("adminOffices");
            }
        }
        [HttpPost]
        public async Task<IActionResult> editSchedule(Schedule schedule)
        {
            if(schedule.Day != null && schedule.Time != null)
            {
                await _scheduleManager.EditSchedule(schedule);
                return RedirectToAction("adminOffices");
            }
            else
            {
                return RedirectToAction("Null");
            }
        }
        [HttpPost]
        public async Task<IActionResult> createSchedule(string scheduleDay, string scheduleTime)
        {
            var db = new TerramarsContext();
            var schedule = db.Schedules.FirstOrDefault(s => s.Day == scheduleDay && s.Time == scheduleTime);
            if(schedule != null)
            {
                return RedirectToAction("SameSchedule");
            }
            else
            {
                await _scheduleManager.CreateSchedule(scheduleDay, scheduleTime);
                return RedirectToAction("adminOffices");
            }
        }
        // конец действий с офисами


    }
}

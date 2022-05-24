using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;

namespace TerraMars.Models
{
    public class AllModels
    {
        public IEnumerable<Cart> Carts { get; set; }
        public IEnumerable<Favorite> Favorites { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Feedback> Feedbacks {  get; set; }
        public IEnumerable<New> News { get; set; }
        public IEnumerable<Office> Offices { get; set; }
        public IEnumerable<Region> Regions { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Schedule> Schedules { get; set; }
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public IEnumerable<Completed> Completeds { get; set; }
        public User user { get; set; }
    }
}

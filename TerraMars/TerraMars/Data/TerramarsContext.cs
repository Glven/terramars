using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TerraMars.Data.Entities;

namespace TerraMars.Data
{
    public class TerramarsContext : DbContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TerramarsContext;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasMany(c => c.Regions)
                .WithMany(s => s.Services)
                .UsingEntity(j => j.ToTable("RegionService"));
            modelBuilder.Entity<Schedule>().HasMany(d => d.Offices)
                .WithMany(l => l.Schedules)
                .UsingEntity(a => a.ToTable("OfficeSchedule"));
        }
    }
}

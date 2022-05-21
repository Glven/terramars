using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Models.Interfaces;
using TerraMars.Data.Entities;
using TerraMars.Data;
using Microsoft.EntityFrameworkCore;

namespace TerraMars.Data.Repositories
{
    public class EmployeesRepository : IEmployee
    {
        private readonly TerramarsContext _context;
        public EmployeesRepository(TerramarsContext context)
        {
            _context = context;
        }

        public async Task<IList<Employee>> AllEmployees() => await _context.Employees.ToListAsync();

        public async Task CreateEmployee(string Photo, string Fullname, string Post, ushort Experience)
        {
            var employee = new Employee { Photo = Photo, Fullname = Fullname, Post = Post, Experience = Experience };
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEmployee(Guid EmployeeId)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == EmployeeId);
            if(employee != null)
            {
                _context.Employees.Remove(employee);
            }
            await _context.SaveChangesAsync();
        }

        public async Task EditEmployee(Employee employee)
        {
            if(employee != null)
            {
                _context.Entry(employee).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}

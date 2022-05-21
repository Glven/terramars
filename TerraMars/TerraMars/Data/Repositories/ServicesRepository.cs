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
    public class ServicesRepository : IService
    {
        private readonly TerramarsContext _context;
        public ServicesRepository(TerramarsContext context)
        {
            _context = context;
        }

        public async Task<IList<Service>> AllServices() => await _context.Services.ToListAsync();

        public async Task CreateService(string serviceName, uint servicePrice)
        {
            var service = new Service { Title = serviceName, Price = servicePrice };
            _context.Services.Add(service);
            await _context.SaveChangesAsync();
        }

        public async Task DeleleService(Guid ServiceId)
        {
            var service = _context.Services.FirstOrDefault(s => s.Id == ServiceId);
            if(service != null)
            {
                _context.Services.Remove(service);
            }
            await _context.SaveChangesAsync();
        }

        public async Task EditService(Service Service)
        {
            if(Service != null)
            {
                _context.Entry(Service).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}

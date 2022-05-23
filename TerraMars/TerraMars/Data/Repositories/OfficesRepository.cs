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
    public class OfficesRepository : IOffice
    {
        private readonly TerramarsContext _context;
        public OfficesRepository(TerramarsContext context)
        {
            _context = context;
        }

        public async Task<IList<Office>> AllOfices() => await _context.Offices.ToListAsync();

        public async Task CreateOffice(string Address, string Description, string Phone, Guid[] ScheduleId)
        {
            var office = new Office { Address = Address, Description = Description, Phone = Phone };
            if(ScheduleId.Length != 0)
            {
                foreach(var schedule in _context.Schedules.Where(co => ScheduleId.Contains(co.Id)))
                {
                    office.Schedules.Add(schedule);
                }
            }
            _context.Offices.Add(office);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOffice(Guid OfficeId)
        {
            var office = _context.Offices.FirstOrDefault(o => o.Id == OfficeId);
            if (office != null)
            {
                _context.Offices.Remove(office);
            }
            await _context.SaveChangesAsync();
        }

        public async Task EditOffice(Office office, Guid[] ScheduleId)
        {
            var newOffice = _context.Offices.Include(o => o.Schedules).FirstOrDefault(o => o.Id == office.Id);
            newOffice.Address = office.Address;
            newOffice.Description = office.Description;
            newOffice.Phone = office.Phone;
            newOffice.Schedules.Clear();
            if (office != null)
            {
                foreach (var schedule in _context.Schedules.Where(s => ScheduleId.Contains(s.Id)))
                {
                    newOffice.Schedules.Add(schedule);
                }
            }
            _context.Entry(newOffice).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

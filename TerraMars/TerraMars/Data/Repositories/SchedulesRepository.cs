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
    public class SchedulesRepository : ISchedule
    {
        private readonly TerramarsContext _context;
        public SchedulesRepository(TerramarsContext context)
        {
            _context = context;
        }

        public async Task CreateSchedule(string Day, string Time)
        {
            var schedule = new Schedule { Day = Day, Time = Time };
            _context.Schedules.Add(schedule);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSchedule(Guid ScheduleId)
        {
            var schedule = _context.Schedules.FirstOrDefault(s => s.Id == ScheduleId);
            if(schedule != null)
            {
                _context.Schedules.Remove(schedule);
            }
            await _context.SaveChangesAsync();
        }

        public async Task EditSchedule(Schedule schedule)
        {
            if(schedule != null)
            {
                _context.Entry(schedule).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Schedule>> GetAll() => await _context.Schedules.ToListAsync();
    }
}

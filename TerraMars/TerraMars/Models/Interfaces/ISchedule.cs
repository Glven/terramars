using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;

namespace TerraMars.Models.Interfaces
{
    public interface ISchedule
    {
        Task<IList<Schedule>> GetAll();
        Task CreateSchedule(string Day, string Time);
        Task EditSchedule(Schedule schedule);
        Task DeleteSchedule(Guid ScheduleId);
    }
}

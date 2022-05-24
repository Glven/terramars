using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TerraMars.Data.Entities;
using TerraMars.Models.Interfaces;

namespace TerraMars.Data.Repositories
{
    public class CompletedsRepository : ICompleted
    {
        private readonly TerramarsContext _context;
        public CompletedsRepository(TerramarsContext context)
        {
            _context = context;
        }

        public async Task<IList<Completed>> AllCompleteds() => await _context.Completeds.ToListAsync();

        public async Task CreateCompleted(string regionPhoto, string regionName, uint regionSquare, uint regionPrice)
        {
            var complete = new Completed { regionPhoto = regionPhoto, regionName = regionName, regionSquare = regionSquare, regionPrice = regionPrice };
            _context.Completeds.Add(complete);
            await _context.SaveChangesAsync();
        }
    }
}

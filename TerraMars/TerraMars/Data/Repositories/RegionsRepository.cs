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
    public class RegionsRepository : IRegion
    {
        private readonly TerramarsContext _context;
        public RegionsRepository(TerramarsContext context)
        {
            _context = context;
        }

        public async Task CreateRegion(string regionPhoto, string regionName, ushort regionSquare, uint regionPrice, Guid[] ServiceId)
        {
            var region = new Region { Photo = regionPhoto, Name = regionName, Square = regionSquare, Price = regionPrice };
            if(ServiceId.Length != 0)
            {
                foreach (var service in _context.Services.Where(s => ServiceId.Contains(s.Id)))
                {
                    region.Services.Add(service);
                }
            }
            _context.Regions.Add(region);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRegion(Guid RegionId)
        {
            var region = _context.Regions.FirstOrDefault(r => r.Id == RegionId);
            if(region != null)
            {
                _context.Regions.Remove(region);
            }
            await _context.SaveChangesAsync();
        }

        public async Task EditRegion(Region region, Guid[] ServiceId)
        {
            var newRegion = _context.Regions.Include(r => r.Services).FirstOrDefault(r => r.Id == region.Id);
            newRegion.Photo = region.Photo;
            newRegion.Name = region.Name;
            newRegion.Square = region.Square;
            newRegion.Price = region.Price;
            newRegion.Services.Clear();
            if(region != null)
            {
                foreach(var service in _context.Services.Where(r => ServiceId.Contains(r.Id)))
                {
                    newRegion.Services.Add(service);
                }
            }
            _context.Entry(newRegion).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Region>> GetAll() => await _context.Regions.ToListAsync();
    }
}

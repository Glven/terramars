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
    public class FavoritesRepository : IFavorite
    {
        private readonly TerramarsContext _context;
        public FavoritesRepository(TerramarsContext context)
        {
            _context = context;
        }

        public async Task CreateFav(Guid RegioId)
        {
            var region = _context.Regions.Include(s => s.Services).FirstOrDefault(r => r.Id == RegioId);
            var fav = new Favorite { Region = region };
            _context.Favorites.Add(fav);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFav(Guid Id)
        {
            var fav = _context.Favorites.FirstOrDefault(f => f.Id == Id);
            if (fav != null)
            {
                _context.Favorites.Remove(fav);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Favorite>> GetAllFav() => await _context.Favorites.ToListAsync();
    }
}

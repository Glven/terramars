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
    public class CartsRepository : ICart
    {
        private readonly TerramarsContext _context;
        public CartsRepository(TerramarsContext context)
        {
            _context = context;
        }

        public async Task<IList<Cart>> AllCart() => await _context.Carts.ToListAsync();

        public async Task CreateCart(Guid RegionId)
        {
            var region = _context.Regions.Include(s => s.Services).FirstOrDefault(r => r.Id == RegionId);
            var cart = new Cart { Region = region };
            _context.Carts.Add(cart);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCart(Guid Id)
        {
            var cart = _context.Carts.FirstOrDefault(f => f.Id == Id);
            if (cart != null)
            {
                _context.Carts.Remove(cart);
            }
            await _context.SaveChangesAsync();
        }
    }
}

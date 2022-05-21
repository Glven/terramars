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
    public class NewsRepository : INew
    {
        private readonly TerramarsContext _context;
        public NewsRepository(TerramarsContext context)
        {
            _context = context;
        }

        public async Task<IList<New>> AllNews() => await _context.News.ToListAsync();

        public async Task CreateNew(string Photo, string Title, string Content)
        {
            var news = new New { Photo = Photo, Title = Title, Content = Content };
            _context.News.Add(news);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNew(Guid NewId)
        {
            var news = _context.News.FirstOrDefault(n => n.Id == NewId);
            if(news != null)
            {
                _context.News.Remove(news);
            }
            await _context.SaveChangesAsync();
        }

        public async Task EditNew(New editnew)
        {
            if(editnew != null)
            {
                _context.Entry(editnew).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
    }
}

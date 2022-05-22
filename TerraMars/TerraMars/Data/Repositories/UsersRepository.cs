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
    public class UsersRepository : IUser
    {
        private readonly TerramarsContext _context;
        public UsersRepository(TerramarsContext context)
        {
            _context = context;
        }

        public async Task CreateUser(string lastname, string name, string secondname, DateTime year, string sex, string mail, string username, string phone, string password)
        {
            var user = new User { Lastname = lastname, Name = name, Secondname = secondname, Year = year, Sex = sex, Mail = mail, Username = username, Phone = phone, Password = password };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(Guid UserId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == UserId);
            if(user != null)
            {
                _context.Users.Remove(user);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<IList<User>> GetAll() => await _context.Users.ToListAsync();
    }
}

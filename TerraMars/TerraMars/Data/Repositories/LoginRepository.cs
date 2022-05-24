using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;
using TerraMars.Models.Interfaces;

namespace TerraMars.Data.Repositories
{
    public class LoginRepository : ILogin 
    {
        private readonly TerramarsContext _context;
        public LoginRepository(TerramarsContext context)
        {
            _context = context;
        }

        public User userReturn(string userLogin, string userPassword)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == userLogin && u.Password == userPassword);
            if(user != null)
            {
                return user;
            }
            return null;
        }
    }
}

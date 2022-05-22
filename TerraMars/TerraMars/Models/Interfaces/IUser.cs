using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;

namespace TerraMars.Models.Interfaces
{
	public interface IUser
	{
		Task<IList<User>> GetAll();
		Task CreateUser(string lastname, string name, string secondname, DateTime year, string sex, string mail, string username, string phone, string password);
		Task DeleteUser(Guid UserId);
	}
}

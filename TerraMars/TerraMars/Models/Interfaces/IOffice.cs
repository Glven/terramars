using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;

namespace TerraMars.Models.Interfaces
{
	public interface IOffice
	{
		Task<IList<Office>> AllOfices();
		Task CreateOffice(string Address, string Description, string Phone, string Schedule);
		Task DeleteOffice(Guid OfficeId);
		Task EditOffice(Office office);
	}
}

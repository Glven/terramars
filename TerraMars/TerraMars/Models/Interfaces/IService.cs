using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;

namespace TerraMars.Models.Interfaces
{
	public interface IService
	{
		Task<IList<Service>> AllServices();
		Task CreateService(string serviceName, uint servicePrice);
		Task DeleleService(Guid ServiceId);
		Task EditService(Service Service);
	}
}

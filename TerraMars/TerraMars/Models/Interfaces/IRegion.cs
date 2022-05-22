using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;

namespace TerraMars.Models.Interfaces
{
	public interface IRegion
	{
		Task<IList<Region>> GetAll();
		Task CreateRegion(string regionPhoto, string regionName, ushort regionSquare, uint regionPrice, Guid[] ServiceId);
		Task EditRegion(Region region, Guid[] ServiceId);
		Task DeleteRegion(Guid RegionId);
	}
}

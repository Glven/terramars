using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;

namespace TerraMars.Models.Interfaces
{
	public interface IFavorite
	{
		Task<IList<Favorite>> GetAllFav();
		Task CreateFav(Guid RegionId);
		Task DeleteFav(Guid Id);
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;

namespace TerraMars.Models.Interfaces
{
	public interface ICart
	{
		Task<IList<Cart>> AllCart();
		Task CreateCart(Guid RegionId);
		Task DeleteCart(Guid Id);
	}
}

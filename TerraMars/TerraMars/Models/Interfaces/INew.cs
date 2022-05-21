using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;


namespace TerraMars.Models.Interfaces
{
	public interface INew
	{
		Task<IList<New>> AllNews();
		Task CreateNew(string Photo, string Title, string Content);
		Task DeleteNew(Guid NewId);
		Task EditNew(New editnew);
	}
}

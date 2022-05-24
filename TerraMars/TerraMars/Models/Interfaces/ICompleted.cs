using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;

namespace TerraMars.Models.Interfaces
{
    public interface ICompleted
    {
        Task<IList<Completed>> AllCompleteds();
        Task CreateCompleted(string regionPhoto, string regionName, uint regionSquare, uint regionPrice);
    }
}

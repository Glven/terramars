using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;

namespace TerraMars.Models.Interfaces
{
	public interface IReview
	{
		Task<IList<Review>> GetReviews();
		Task CreateReview(Guid UserId, int reviewGrade, string reviewComment);
		Task DeleteReview(Guid ReviewId);
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TerraMars.Data.Entities;
using TerraMars.Models.Interfaces;

namespace TerraMars.Data.Repositories
{
    public class ReviewsRepository : IReview
    {
        private readonly TerramarsContext _context;
        public ReviewsRepository(TerramarsContext context)
        {
            _context = context;
        }

        public async Task CreateReview(Guid UserId, int reviewGrade, string reviewComment)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == UserId);
            var review = new Review { Grade = reviewGrade, Comment = reviewComment, Time = DateTime.Now, User = user };
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReview(Guid ReviewId)
        {
            var review = _context.Reviews.FirstOrDefault(r => r.Id == ReviewId);
            if(review != null)
            {
                _context.Reviews.Remove(review);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Review>> GetReviews() => await _context.Reviews.ToListAsync();
    }
}

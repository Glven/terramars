using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Models.Interfaces;
using TerraMars.Data.Entities;
using TerraMars.Data;
using Microsoft.EntityFrameworkCore;

namespace TerraMars.Data.Repositories
{
    public class FeedbacksRepository : IFeedback
    {
        private readonly TerramarsContext _context;
        public FeedbacksRepository(TerramarsContext context)
        {
            _context = context;
        }

        public async Task<IList<Feedback>> AllFeedbacks() => await _context.Feedbacks.ToListAsync();

        public async Task CreateFeedback(string Name, string Phone, string Mail, string Message)
        {
            var feedback = new Feedback { Name = Name, Phone = Phone, Mail = Mail, Message = Message };
            _context.Feedbacks.Add(feedback);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFeedback(Guid FeedbackId)
        {
            var feedback = _context.Feedbacks.FirstOrDefault(f => f.Id == FeedbackId);
            if(feedback != null)
            {
                _context.Feedbacks.Remove(feedback);
            }
            await _context.SaveChangesAsync();
        }
    }
}

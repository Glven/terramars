using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;


namespace TerraMars.Models.Interfaces
{
	public interface IFeedback
	{
		Task<IList<Feedback>> AllFeedbacks();
		Task CreateFeedback(string Name, string Phone, string Mail, string Message);
		Task DeleteFeedback(Guid FeedbackId);
	}
}

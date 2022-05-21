using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TerraMars.Data.Entities
{
	public class Office
	{
		[Key]
		public Guid Id { get; set; }
		public string Address { get; set; }
		public string Description { get; set; }
		public string Phone { get; set; }
		public IList<Schedule> Schedules { get; set; } = new List<Schedule>();
	}
}

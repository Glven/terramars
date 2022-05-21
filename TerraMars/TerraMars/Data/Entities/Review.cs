using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerraMars.Data.Entities
{
	public class Review
	{
		[Key]
		[ForeignKey("User")]
		public Guid Id { get; set; }
		public DateTime Time { get; set; }
		public double Grade { get; set; }
		public string Comment { get; set; }
		public User User { get; set; }
	}
}

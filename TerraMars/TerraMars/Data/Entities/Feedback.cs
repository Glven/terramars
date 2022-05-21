using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TerraMars.Data.Entities
{
	public class Feedback
	{
		[Key]
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
		public string Mail { get; set; }
		public string Message { get; set; }
	}
}

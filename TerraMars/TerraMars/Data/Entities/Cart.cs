using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TerraMars.Data.Entities
{
	public class Cart
	{
		[Key]
		public Guid Id { get; set; }
		public Region Region { get; set; }
	}
}

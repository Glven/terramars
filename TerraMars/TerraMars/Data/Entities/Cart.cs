using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerraMars.Data.Entities
{
	public class Cart
	{
		[Key]
		[ForeignKey("Region")]
		public Guid Id { get; set; }
		public Region Region { get; set; }
	}
}

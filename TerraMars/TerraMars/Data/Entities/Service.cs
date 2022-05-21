using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TerraMars.Data.Entities
{
	public class Service
	{
		[Key]
		public Guid Id { get; set; }
		public string Title { get; set; }
		public uint Price { get; set; }
		public virtual IList<Region> Regions { get; set; } = new List<Region>();
	}
}

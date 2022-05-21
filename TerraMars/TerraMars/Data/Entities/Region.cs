using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TerraMars.Data.Entities
{
	public class Region
	{
		[Key]
		public Guid Id {  get; set; }
		public string Photo { get; set; }
		public string Name { get; set; }
		public ushort Square { get; set; }
		public uint Price { get; set; }
		public virtual IList<Service> Services { get; set; } = new List<Service>();
	}
}

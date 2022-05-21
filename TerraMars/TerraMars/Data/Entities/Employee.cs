using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TerraMars.Data.Entities
{
	public class Employee
	{
		[Key]
		public Guid Id { get; set; }
		public string Photo { get; set; }
		public string Fullname { get; set; }
		public string Post { get; set; }
		public ushort Experience { get; set; }

	}
}

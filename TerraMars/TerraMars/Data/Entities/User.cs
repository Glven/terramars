using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TerraMars.Data.Entities
{
	public class User
	{
		public Guid Id { get; set; }
		public string Lastname { get; set; }
		public string Name { get; set; }
		public string Secondname { get; set; }
		public DateTime Year { get; set; }
		public string Sex { get; set; }
		public string Mail { get; set; }
		public string Username { get; set; }
		public string Phone { get; set; }
		public string Password { get; set; }
		public Review Review { get; set; }
	}
}

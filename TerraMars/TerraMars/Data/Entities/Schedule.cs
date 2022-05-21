using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TerraMars.Data.Entities
{
    public class Schedule
    {
        [Key]
        public Guid Id { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public IList<Office> Offices { get; set; } = new List<Office>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TerraMars.Data.Entities
{
    public class Completed
    {
        [Key]
        public Guid Id { get; set; }
        public string regionPhoto { get; set; }
        public string regionName { get; set; }
        public uint regionSquare { get; set; }
        public uint regionPrice { get; set; }
    }
}

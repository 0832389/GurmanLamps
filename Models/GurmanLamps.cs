using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GurmanLamps.Models
{
    public class Lamps
    {
        public int Id { get; set; }
        public string Type { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        public string MaterialUsed { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public string LampColor { get; set; }

        public string BulbColor { get; set; }
    }
}
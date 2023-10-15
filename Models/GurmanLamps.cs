using System;
using System.ComponentModel.DataAnnotations;

namespace GurmanLamps.Models
{
    public class Lamps
    {
        public int Id { get; set; }
        public string Type { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        public string MaterialUsed { get; set; }
        public decimal Price { get; set; }

        public string LampColor { get; set; }

        public string BulbColor { get; set; }
    }
}
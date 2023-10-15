using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GurmanLamps.Models;

namespace GurmanLamps.Data
{
    public class GurmanLampsContext : DbContext
    {
        public GurmanLampsContext (DbContextOptions<GurmanLampsContext> options)
            : base(options)
        {
        }

        public DbSet<GurmanLamps.Models.Lamps> Lamps { get; set; }
    }
}



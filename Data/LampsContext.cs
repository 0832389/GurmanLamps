using Microsoft.EntityFrameworkCore;
using GurmanLamps.Models;

namespace GurmanLamps.Data
{
    public class GurmanLampsContext : DbContext
    {
        public GurmanLampsContext(DbContextOptions<GurmanLampsContext> options)
            : base(options)
        {
        }

        public DbSet<Lamps> GurmanLamps { get; set; }
    }
}
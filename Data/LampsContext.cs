using Microsoft.EntityFrameworkCore;
using GurmanLamps.Models;

namespace GurmanLamps.Data
{
    public class LampsContext : DbContext
    {
        public LampsContext(DbContextOptions<LampsContext> options)
            : base(options)
        {
        }

        public DbSet<Lamps> GurmanLamps { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GurmanLamps.Data;
using System;
using System.Linq;

namespace GurmanLamps.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GurmanLampsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GurmanLampsContext>>()))
            {
                // Look for any Lamps.
                if (context.GurmanLamps.Any())
                {
                    return;   // DB has been seeded
                }

                context.GurmanLamps.AddRange(
                   

                    new Lamps
                    {
                        Type = "flickering",
                        ManufacturingDate = DateTime.Parse("2021-04-23"),
                        MaterialUsed = "bulb, cord, metal",
                        Price = 8.99M,
                        LampColor = "Black"  ,
                        BulbColor="white"
                    },

                     new Lamps
                     {
                         Type = "flickering",
                         ManufacturingDate = DateTime.Parse("2021-04-23"),
                         MaterialUsed = "bulb, cord, metal",
                         Price = 8.99M,
                         LampColor = "Black",
                         BulbColor = "white"
                     },

                      new Lamps
                      {
                          Type = "flickering",
                          ManufacturingDate = DateTime.Parse("2021-04-23"),
                          MaterialUsed = "bulb, cord, metal",
                          Price = 8.99M,
                          LampColor = "Black",
                          BulbColor = "white"
                      },

                       new Lamps
                       {
                           Type = "flickering",
                           ManufacturingDate = DateTime.Parse("2021-04-23"),
                           MaterialUsed = "bulb, cord, metal",
                           Price = 8.99M,
                           LampColor = "Black",
                           BulbColor = "white"
                       },

                        new Lamps
                        {
                            Type = "flickering",
                            ManufacturingDate = DateTime.Parse("2021-04-23"),
                            MaterialUsed = "bulb, cord, metal",
                            Price = 8.99M,
                            LampColor = "Black",
                            BulbColor = "white"
                        },

                         new Lamps
                         {
                             Type = "flickering",
                             ManufacturingDate = DateTime.Parse("2021-04-23"),
                             MaterialUsed = "bulb, cord, metal",
                             Price = 8.99M,
                             LampColor = "Black",
                             BulbColor = "white"
                         }


                );
                context.SaveChanges();
            }
        }
    }
}

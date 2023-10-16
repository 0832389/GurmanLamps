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
                        Type = "baby blower",
                        ManufacturingDate = DateTime.Parse("2023-08-31"),
                        MaterialUsed = "bulb, cord, metal",
                        Price = 20.55M,
                        LampColor = "white",
                        BulbColor="white"
                    },

                     new Lamps
                     {
                         Type = "Two Light Lamp	",
                         ManufacturingDate = DateTime.Parse("2012-02-02	"),
                         MaterialUsed = "plug, electrical cord, bulbs and socket kit.",
                         Price = 20.00M,
                         LampColor = "blue",
                         BulbColor = "white"
                     },

                      new Lamps
                      {
                          Type = "metal lamp",
                          ManufacturingDate = DateTime.Parse("2020-09-12"),
                          MaterialUsed = "plug, electrical cord, bulbs and socket kit.",
                          Price = 20.55M,
                          LampColor = "Black",
                          BulbColor = "white"
                      },

                       new Lamps
                       {
                           Type = "flueroscent lamps	",
                           ManufacturingDate = DateTime.Parse("2016-05-24"),
                           MaterialUsed = "plug, electrical cord, bulbs and socket kit and flueroscent.",
                           Price = 15.60M,
                           LampColor = "Golden",
                           BulbColor = "golden"
                       },

                        new Lamps
                        {
                            Type = "charging lamps",
                            ManufacturingDate = DateTime.Parse("1998-10-27"),
                            MaterialUsed = "plug, electrical cord, bulbs and socket kit and battery.",
                            Price = 40.90M,
                            LampColor = "Red",
                            BulbColor = "Red"
                        },

                         new Lamps
                         {
                             Type = "simple bulb lamp",
                             ManufacturingDate = DateTime.Parse("2012-09-09"),
                             MaterialUsed = "plug, electrical cord, bulbs and socket kit.",
                             Price = 12.90M,
                             LampColor = "green",
                             BulbColor = "golden"
                         },
                         new Lamps
                         {
                             Type = "glitter plastic lamps",
                             ManufacturingDate = DateTime.Parse("2019-07-07"),
                             MaterialUsed = "plug, electrical cord, bulbs and socket kit and glitter plastic.",
                             Price = 10.00M,
                             LampColor = "pink",
                             BulbColor = "white"
                         },
                         new Lamps
                         {
                             Type = "special bulb lamps",
                             ManufacturingDate = DateTime.Parse("2020-09-09"),
                             MaterialUsed = "plug, electrical cord, bulbs and socket kit.",
                             Price = 50.00M,
                             LampColor = "pink",
                             BulbColor = "pink"
                         },
                         new Lamps
                         {
                             Type = "table lamps",
                             ManufacturingDate = DateTime.Parse("2022-08-08"),
                             MaterialUsed = "plug, electrical cord, bulbs and socket kit.",
                             Price = 15.50M,
                             LampColor = "white",
                             BulbColor = "white"
                         },
                         new Lamps
                         {
                             Type = "study lamps",
                             ManufacturingDate = DateTime.Parse("2020-05-08"),
                             MaterialUsed = "plug, electrical cord, bulbs and socket kit and battery.",
                             Price = 15.60M,
                             LampColor = "white",
                             BulbColor = "white"
                         }


                );
                context.SaveChanges();
            }
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GurmanLamps.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GurmanLamps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    ManufacturingDate = table.Column<DateTime>(nullable: false),
                    MaterialUsed = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    LampColor = table.Column<string>(nullable: true),
                    BulbColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GurmanLamps", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GurmanLamps");
        }
    }
}

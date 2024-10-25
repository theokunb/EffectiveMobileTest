using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EffectiveMobileTest.Migrations
{
    /// <inheritdoc />
    public partial class addedOrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    CityDistrictId = table.Column<Guid>(type: "uuid", nullable: false),
                    DeliveryDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}

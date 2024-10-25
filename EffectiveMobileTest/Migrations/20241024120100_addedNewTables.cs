using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EffectiveMobileTest.Migrations
{
    /// <inheritdoc />
    public partial class addedNewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DeliveryDateTime",
                table: "Orders",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.CreateTable(
                name: "FilteredOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilteredOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FiltersAndOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FilteredOrdersId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiltersAndOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FiltersAndOrders_FilteredOrders_FilteredOrdersId",
                        column: x => x.FilteredOrdersId,
                        principalTable: "FilteredOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FiltersAndOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FiltersAndOrders_FilteredOrdersId",
                table: "FiltersAndOrders",
                column: "FilteredOrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_FiltersAndOrders_OrderId",
                table: "FiltersAndOrders",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FiltersAndOrders");

            migrationBuilder.DropTable(
                name: "FilteredOrders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeliveryDateTime",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}

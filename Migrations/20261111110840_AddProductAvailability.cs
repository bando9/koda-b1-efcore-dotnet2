using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KodaStore.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddProductAvailability : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: "PR01");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: "PR02");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: "PR03");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeactivatedUtc",
                schema: "dbo",
                table: "Product",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "dbo",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeactivatedUtc",
                schema: "dbo",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "dbo",
                table: "Product");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Product",
                columns: new[] { "ProductCode", "Category", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { "PR01", "Mie Ayam", null, "Mie Ayam Yamin", 13000m, 250 },
                    { "PR02", "Bakso", "bakso urat besar, lainnya kecil", "Bakso Campuran", 17000m, 250 },
                    { "PR03", "Bakso", "Bakso dg tetelan daging", "Bakso Halus", 15000m, 210 }
                });
        }
    }
}

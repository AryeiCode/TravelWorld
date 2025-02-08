using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelWorld.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedAddCountryHouse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CountryHouses",
                columns: new[] { "Id", "Created_Date", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "Updated_Date" },
                values: new object[,]
                {
                    { 1, null, "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x400", "Royal CountryHouse", 4, 200.0, 550.0, null },
                    { 2, null, "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x401", "Premium Pool CountryHouse", 4, 300.0, 550.0, null },
                    { 3, null, "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://placehold.co/600x402", "Luxury Pool CountryHouse", 4, 400.0, 750.0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CountryHouses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CountryHouses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CountryHouses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

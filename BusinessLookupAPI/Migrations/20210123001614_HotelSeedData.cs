using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLookupAPI.Migrations
{
    public partial class HotelSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Address", "Name", "Stars" },
                values: new object[,]
                {
                    { 1, "7801 NE Greenwood Dr, Vancouver, WA 98662", "The Heathman Lodge", 3 },
                    { 2, "301 W 6th St, Vancouver, WA 98660", "Hilton Vancouver Washington", 4 },
                    { 3, "314 W 11th St, Vancouver, WA 98660", "The Briar Rose Inn", 2 },
                    { 4, "701 SE Columbia Shores Blvd, Vancouver, WA 98661", "Homewood Suites by Hilton Vancouver", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 4);
        }
    }
}

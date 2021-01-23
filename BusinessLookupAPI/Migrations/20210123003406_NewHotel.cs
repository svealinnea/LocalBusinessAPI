using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLookupAPI.Migrations
{
    public partial class NewHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Address", "Name", "Stars" },
                values: new object[] { 5, "1500 SE 167th Ave, Vancouver, WA 98683", "Best Western Premier Hotel at Fisher's Landing", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 5);
        }
    }
}

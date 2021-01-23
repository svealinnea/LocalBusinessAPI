using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLookupAPI.Migrations
{
    public partial class HotelStars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stars",
                table: "Hotels",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stars",
                table: "Hotels");
        }
    }
}

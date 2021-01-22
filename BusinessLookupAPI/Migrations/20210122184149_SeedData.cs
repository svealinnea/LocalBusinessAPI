using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLookupAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "1220 Main St #100, Vancouver, WA 98660", "Amaro’s Table" },
                    { 2, "777 Waterfront Way Suite 101, Vancouver, WA 98660", "WildFin American Grill" },
                    { 3, "108 W 8th St, Vancouver, WA 98660", "Moo Burgers and Beer" },
                    { 4, "213 W 11th St, Vancouver, WA 98660", "Thai Orchid Restaurant" },
                    { 5, "108 E 7th St Suite B, Vancouver, WA 98660", "Slow Fox Chili" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "7950 E Mill Plain Blvd, Vancouver, WA 98664", "The Mill" },
                    { 2, "221E NE 104th Ave, Vancouver, WA 98664", "Walmart Supercenter" },
                    { 3, "330 NE Chkalov Dr, Vancouver, WA 98684", "The Herbery" },
                    { 4, "14201 SE Mill Plain Blvd E, Vancouver, WA 98684", "Planet Smoke and Vape" },
                    { 5, "13503 SE Mill Plain Blvd, Vancouver, WA 98684", "Spanky's Legendary Consignment" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 5);
        }
    }
}

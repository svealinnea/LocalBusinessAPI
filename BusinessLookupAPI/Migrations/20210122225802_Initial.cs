﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLookupAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    ShopId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopId);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "Name" },
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
            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}

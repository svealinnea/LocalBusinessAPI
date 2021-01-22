﻿// <auto-generated />
using BusinessLookupApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusinessLookupAPI.Migrations
{
    [DbContext(typeof(BusinessLookupApiContext))]
    [Migration("20210122234925_Hotel")]
    partial class Hotel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BusinessLookupApi.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("HotelId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("BusinessLookupApi.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            Address = "1220 Main St #100, Vancouver, WA 98660",
                            Name = "Amaro’s Table"
                        },
                        new
                        {
                            RestaurantId = 2,
                            Address = "777 Waterfront Way Suite 101, Vancouver, WA 98660",
                            Name = "WildFin American Grill"
                        },
                        new
                        {
                            RestaurantId = 3,
                            Address = "108 W 8th St, Vancouver, WA 98660",
                            Name = "Moo Burgers and Beer"
                        },
                        new
                        {
                            RestaurantId = 4,
                            Address = "213 W 11th St, Vancouver, WA 98660",
                            Name = "Thai Orchid Restaurant"
                        },
                        new
                        {
                            RestaurantId = 5,
                            Address = "108 E 7th St Suite B, Vancouver, WA 98660",
                            Name = "Slow Fox Chili"
                        });
                });

            modelBuilder.Entity("BusinessLookupApi.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ShopId");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            ShopId = 1,
                            Address = "7950 E Mill Plain Blvd, Vancouver, WA 98664",
                            Name = "The Mill"
                        },
                        new
                        {
                            ShopId = 2,
                            Address = "221E NE 104th Ave, Vancouver, WA 98664",
                            Name = "Walmart Supercenter"
                        },
                        new
                        {
                            ShopId = 3,
                            Address = "330 NE Chkalov Dr, Vancouver, WA 98684",
                            Name = "The Herbery"
                        },
                        new
                        {
                            ShopId = 4,
                            Address = "14201 SE Mill Plain Blvd E, Vancouver, WA 98684",
                            Name = "Planet Smoke and Vape"
                        },
                        new
                        {
                            ShopId = 5,
                            Address = "13503 SE Mill Plain Blvd, Vancouver, WA 98684",
                            Name = "Spanky's Legendary Consignment"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace BusinessLookupApi.Models
{
  public class BusinessLookupApiContext : DbContext
  {
    public BusinessLookupApiContext(DbContextOptions<BusinessLookupApiContext> options)
          : base(options)
    {
    }
    public DbSet<Shop> Shops { get; set; }
    public DbSet<Business> Businesses { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Shop>()
        .HasData(
          new Shop { ShopId = 1, Name = "The Mill", Address = "7950 E Mill Plain Blvd, Vancouver, WA 98664" },
          new Shop { ShopId = 2, Name = "Walmart Supercenter", Address = "221E NE 104th Ave, Vancouver, WA 98664" },
          new Shop { ShopId = 3, Name = "The Herbery", Address = "330 NE Chkalov Dr, Vancouver, WA 98684"},
          new Shop { ShopId = 4, Name = "Planet Smoke and Vape",  Address = "14201 SE Mill Plain Blvd E, Vancouver, WA 98684"},
          new Shop { ShopId = 5, Name = "Spanky's Legendary Consignment", Address = "13503 SE Mill Plain Blvd, Vancouver, WA 98684" }
        );
    // }
    // public DbSet<Business> Businesses { get; set; }
          builder.Entity<Business>().HasData(
          new Business { BusinessId = 1, Name = "Amaro’s Table", Address = "1220 Main St #100, Vancouver, WA 98660" },
          new Business { BusinessId = 2, Name = "WildFin American Grill", Address = "777 Waterfront Way Suite 101, Vancouver, WA 98660" },
          new Business { BusinessId = 3, Name = "Moo Burgers and Beer", Address = "108 W 8th St, Vancouver, WA 98660"},
          new Business { BusinessId = 4, Name = "Thai Orchid Restaurant",  Address = "213 W 11th St, Vancouver, WA 98660"},
          new Business { BusinessId = 5, Name = "Slow Fox Chili", Address = "108 E 7th St Suite B, Vancouver, WA 98660" }
        );
    }
  }
  //       protected override void OnModelCreating(ModelBuilder builder)
  //   {
  //     builder.Entity<Business>()
  //       .HasData(
  //         new Business { BusinessId = 1, Name = "Amaro’s Table", Address = "1220 Main St #100, Vancouver, WA 98660" },
  //         new Business { BusinessId = 2, Name = "", Address = "" },
  //         new Business { BusinessId = 3, Name = "", Address = ""},
  //         new Business { BusinessId = 4, Name = "",  Address = " "},
  //         new Business { BusinessId = 5, Name = "", Address = "" }
  //       );
  // }
}
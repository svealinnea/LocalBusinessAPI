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
  }
}
using System.ComponentModel.DataAnnotations;

namespace BusinessLookupApi.Models
{
  public class Shop
  {
    public int ShopId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    [StringLength(200)]
    public string Address { get; set; }
  }
}
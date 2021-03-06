using System.ComponentModel.DataAnnotations;

namespace BusinessLookupApi.Models
{
  public class Restaurant 
  {
    public int RestaurantId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    [StringLength(200)]    
    public string Address { get; set; }
  }
}
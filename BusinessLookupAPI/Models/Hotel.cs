using System.ComponentModel.DataAnnotations;

namespace BusinessLookupApi
{
  public class Hotel
  {
    public int HotelId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    [StringLength(200)]  
    public string Address { get; set; }

  }
}
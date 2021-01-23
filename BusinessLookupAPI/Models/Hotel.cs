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

    [Required]
    [Range (0, 5, ErrorMessage= "Hotels can only have up to 5 stars and no less then 0 stars") ]
    public int Stars { get; set; }
  }
}
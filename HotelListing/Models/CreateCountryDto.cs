using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateCountryDto
    {
        [Required]
        [StringLength(50, ErrorMessage = "Country name is too long.")]
        public string Name { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "Country short name is too long.")]
        public string ShortName { get; set; }
    }
}

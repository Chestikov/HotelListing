using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateHotelDto
    {
        [Required]
        [StringLength(150, ErrorMessage = "Hotel name is too long")]
        public string Name { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Address is too long")]
        public string Address { get; set; }

        [Required]
        [Range(1, 5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}

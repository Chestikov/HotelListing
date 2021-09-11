using System.Collections.Generic;

namespace HotelListing.Models
{
    public class CountryDto : CreateCountryDto
    {
        public int Id { get; set; }

        public IList<HotelDto> Hotels {  get; set; }
    }
}

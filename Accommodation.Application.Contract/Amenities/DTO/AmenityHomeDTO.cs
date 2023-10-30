using System.Collections.Generic;

namespace Accommodation.Application.Contract.Amenities.DTO
{
    public class AmenityHomeDTO
    {
        public List<AmenityDTO> Amenities { get; set; }
        public  CreateAmenityDTO NewAmenity { get; set; }
    }
}
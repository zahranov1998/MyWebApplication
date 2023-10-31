using System.Collections.Generic;
using Accommodation.Application.Contract.Amenities.DTO;

namespace Accommodation.Application.Contract.ViewModels
{
    public class HotelDTOViewModel
    {
        public int Id { get; set; }

        public string NativeName  { get; set; }

        public string LatinName { get; set; }

        public string District { get; set; }

        public string Description { get; set; }

        public string Rules { get; set; }

        public List<AmenityDTO> Amenities { get; set; }
    }
}
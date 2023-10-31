using Accommodation.Application.Contract.Amenities.DTO;
using Accommodation.Application.Contract.Hotels.DTO;
using System.Collections.Generic;
using Accommodation.Application.Contract.HotelGroups.DTO;

namespace Accommodation.Application.Contract.ViewModels
{
    public class AddHotelViewModel
    {
        public List<AmenityDTO> Amenities { get; set; }

        public HotelDTO Hotel { get; set; }

        public List<AmenityCheckbox> AmenityCheckboxes { get; set; }

        public IEnumerable<HotelGroupDTO> HotelGroups { get; set; }
    }
}
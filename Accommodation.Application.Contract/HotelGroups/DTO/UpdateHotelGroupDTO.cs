using Accommodation.Application.Contract.Hotels.DTO;
using System.Collections.Generic;

namespace Accommodation.Application.Contract.HotelGroups.DTO
{
    public class UpdateHotelGroupDTO
    {
        public int Id { get; set; }

        public string LatinTitle { get; set; }

        public string NativeTitle { get; set; }

        public int CityId { get; set; }

        public List<HotelDTO> Hotels { get; set; }
    }
}
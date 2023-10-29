using System.Collections.Generic;

namespace Accommodation.Application.Contract.Hotels.DTO
{
    public class UpdateHotelDTO
    {
        public int Id { get; set; }

        public string LatinName { get; set; }

        public string NativeName { get; set; }

        public string District { get; set; }

        public List<int> AmenityIds { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public List<int> RoomIds { get; set; }

        public string Rules { get; set; }

        public List<int> TagIds { get; set; }

        public int HotelGroupId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
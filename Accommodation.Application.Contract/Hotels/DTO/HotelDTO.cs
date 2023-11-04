using Accommodation.Application.Contract.Amenities.DTO;
using Accommodation.Application.Contract.Rooms.DTO;
using Accommodation.Application.Contract.Tags.DTO;
using System.Collections.Generic;

namespace Accommodation.Application.Contract.Hotels.DTO
{
    public class HotelDTO
    {
        public int Id { get; set; }

        public string LatinName { get; set; }

        public string NativeName { get; set; }

        public string District { get; set; }

        public List<AmenityDTO> AllAmenities { get; set; }

        public List<AmenityDTO> Amenities { get; set; }

        public string[] AvailableAmenities { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public List<RoomDTO> Rooms { get; set; }

        public string Rules { get; set; }

        public List<TagDTO> Tags { get; set; }

        public int HotelGroupId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
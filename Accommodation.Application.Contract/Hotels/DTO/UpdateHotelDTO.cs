using Accommodation.Application.Contract.Amenities.DTO;
using Accommodation.Application.Contract.Rooms.DTO;
using Accommodation.Application.Contract.Tags.DTO;
using System.Collections.Generic;

namespace Accommodation.Application.Contract.Hotels.DTO
{
    public class UpdateHotelDTO
    {
        public int Id { get; set; }

        public string LatinName { get; set; }

        public string NativeName { get; set; }

        public string District { get; set; }

        public List<int> Amenities { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public List<UpdateRoomDTO> Rooms { get; set; }

        public string Rules { get; set; }

        public List<UpdateTagDTO> Tags { get; set; }

        public int HotelGroupId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
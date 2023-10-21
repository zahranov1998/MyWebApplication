using Accommodation.Application.Contract.Hotels.DTO;
using Accommodation.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.Application.Mappers
{
    public static class HotelMapper
    {

        public static List<HotelDTO> MapToDTOs(List<Hotel> hotels)
        {
            return hotels.Select(h => MapToDTO(h)).ToList();
        }

        public static HotelDTO MapToDTO(Hotel hotel)

        {
            return new HotelDTO()
            {
                Amenities = AmenityMapper.MapToDTOs(hotel.Amenities),
                Description = hotel.Description,
                District = hotel.District,
                HotelGroupId = hotel.HotelGroupId,
                IsDeleted = hotel.IsDeleted,
                LatinName = hotel.LatinName,
                Location = hotel.LatinName,
                NativeName = hotel.NativeName,
                Rooms = RoomMapper.MapToDTOs(hotel.Rooms),
                Rules = hotel.Rules,
                Tags = TagMapper.MapToDTOs(hotel.Tags)
            };
        }
    }
}
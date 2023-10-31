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
            var amenities = AmenityMapper.MapToDTOs(hotel.Amenities);
            var rooms = RoomMapper.MapToDTOs(hotel.Rooms);
            var tags = TagMapper.MapToDTOs(hotel.Tags);

            return new HotelDTO()
            {
                Id = hotel.Id,
                Amenities = amenities,
                Description = hotel.Description,
                District = hotel.District,
                HotelGroupId = hotel.HotelGroupId,
                IsDeleted = hotel.IsDeleted,
                LatinName = hotel.LatinName,
                Location = hotel.LatinName,
                NativeName = hotel.NativeName,
                Rooms = rooms,
                Rules = hotel.Rules,
                Tags = tags
            };
        }
    }
}
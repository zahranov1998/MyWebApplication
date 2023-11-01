using Accommodation.Application.Contract.HotelGroups.DTO;
using Accommodation.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.Application.Mappers
{
    public static class HotelGroupMapper
    {
        public static HotelGroupDTO MapToDTO(HotelGroup hotelGroup)
        {
            return new HotelGroupDTO()
            {
                Id = hotelGroup.Id,
                CityId = hotelGroup.CityId,
                LatinTitle = hotelGroup.LatinTitle,
                NativeTitle = hotelGroup.NativeTitle
            };
        }

        public static List<HotelGroupDTO> MapToDTOs(List<HotelGroup> hotelGroups) 
        {
            return hotelGroups.Select(h=> MapToDTO(h)).ToList();
        }
    }
}
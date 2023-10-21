using Accommodation.Application.Contract.HotelGroups.DTO;
using Accommodation.Domain.Models;

namespace Accommodation.Application.Mappers
{
    public static class HotelGroupMapper
    {
        public static HotelGroupDTO MapToDTO(HotelGroup hotelGroup)
        {
            return new HotelGroupDTO()
            {
                CityId = hotelGroup.CityId,
                Hotels = HotelMapper.MapToDTOs(hotelGroup.Hotels),
                LatinTitle = hotelGroup.LatinTitle,
                NativeTitle = hotelGroup.NativeTitle
            };
        }
    }
}
using Accommodation.Application.Contract.HotelGroups.DTO;
using Accommodation.Domain.Models;

namespace Accommodation.Application.Mappers
{
    public static class HotelGroupMapper
    {
        public static HotelGroupDTO MapToDTO(HotelGroup hotelGroup)
        {
            var hotels = HotelMapper.MapToDTOs(hotelGroup.Hotels);

            return new HotelGroupDTO()
            {
                CityId = hotelGroup.CityId,
                Hotels = hotels,
                LatinTitle = hotelGroup.LatinTitle,
                NativeTitle = hotelGroup.NativeTitle
            };
        }
    }
}
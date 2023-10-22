using Accommodation.Application.Contract.HotelGroups.DTO;

namespace Accommodation.Application.Contract.HotelGroups.Services
{
    public interface IHotelGroupService
    {
        void CreateHotelGroup(HotelGroupDTO hotelGroupDTO);

        HotelGroupDTO GetHotelGroupById(int id);
    }
}
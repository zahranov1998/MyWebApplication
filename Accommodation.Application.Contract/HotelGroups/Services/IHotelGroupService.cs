using Accommodation.Application.Contract.HotelGroups.DTO;
using System.Collections.Generic;

namespace Accommodation.Application.Contract.HotelGroups.Services
{
    public interface IHotelGroupService
    {
        void CreateHotelGroup(HotelGroupDTO hotelGroupDTO);

        HotelGroupDTO GetHotelGroupById(int id);

        List<HotelGroupDTO> GetALLHotelGroups();
    }
}
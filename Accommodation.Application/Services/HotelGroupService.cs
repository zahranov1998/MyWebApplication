using Accommodation.Application.Contract.HotelGroups.DTO;
using Accommodation.Application.Contract.HotelGroups.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;

namespace Accommodation.Application.Services
{
    public class HotelGroupService : IHotelGroupService
    {
        public readonly IHotelGroupRepository HotelGroupRepository;

        public HotelGroupService()
        {
            var context = new AccommodationDbContext();

            HotelGroupRepository = new HotelGroupRepository(context);
        }

        public void CreateHotelGroup(HotelGroupDTO hotelGroupDTO)
        {
            var hotelGroup = new HotelGroup(hotelGroupDTO.LatinTitle, hotelGroupDTO.NativeTitle, hotelGroupDTO.CityId);

            HotelGroupRepository.Create(hotelGroup);
        }

        public HotelGroupDTO GetHotelGroupById(int id)
        {
            var hotelGroup = HotelGroupRepository.GetById(id);

            return HotelGroupMapper.MapToDTO(hotelGroup);
        }
    }
}
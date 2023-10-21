using Accommodation.Application.Contract.Hotels.DTO;
using Accommodation.Application.Contract.Hotels.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;

namespace Accommodation.Application.Services
{
    public class HotelService : IHotelService
    {
        public readonly IHotelRepository HotelRepository;

        public HotelService()
        {
            var context = new AccommodationDbContext();

            HotelRepository = new HotelRepository(context);
        }

        public void CreateHotel(HotelDTO hotelDTO)
        {
            var hotel = new Hotel(hotelDTO.LatinName, hotelDTO.NativeName, hotelDTO.District, AmenityMapper.MapDTOsToModelList(hotelDTO.Amenities), hotelDTO.Location,
            hotelDTO.Description, RoomMapper.MapToModelList(hotelDTO.Rooms), hotelDTO.Rules, TagMapper.MapToModelList(hotelDTO.Tags), hotelDTO.HotelGroupId, hotelDTO.IsDeleted);

            HotelRepository.AddHotel(hotel);
        }

        public HotelDTO GetHotelById(int id)
        {
            var hotel = HotelRepository.GetById(id);

            return HotelMapper.MapToDTO(hotel);
        }
    }
}
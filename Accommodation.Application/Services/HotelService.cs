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
            var amenities = AmenityMapper.MapDTOsToModelList(hotelDTO.Amenities);
            var tags = TagMapper.MapToModelList(hotelDTO.Tags);
            var rooms = RoomMapper.MapToModelList(hotelDTO.Rooms);

            var hotel = new Hotel(hotelDTO.LatinName, hotelDTO.NativeName, hotelDTO.District, amenities, hotelDTO.Location,hotelDTO.Description, rooms, hotelDTO.Rules, tags, hotelDTO.HotelGroupId);

            HotelRepository.Create(hotel);
        }

        public HotelDTO GetHotelById(int id)
        {
            var hotel = HotelRepository.GetById(id);

            return HotelMapper.MapToDTO(hotel);
        }
    }
}
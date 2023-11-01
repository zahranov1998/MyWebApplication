using Accommodation.Application.Contract.Hotels.DTO;
using Accommodation.Application.Contract.Hotels.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;
using System.Collections.Generic;
using System.Linq;
using Accommodation.Application.Contract.Amenities.DTO;

namespace Accommodation.Application.Services
{
    public class HotelService : IHotelService
    {
        public readonly IHotelRepository hotelRepository;
        public readonly IAmenityRepository amenityRepository;
        public readonly ITagRepository tagRepository;
        public readonly IRoomRepository roomRepository;

        public HotelService()
        {
            var context = new AccommodationDbContext();

            hotelRepository = new HotelRepository(context);
            amenityRepository = new AmenityRepository(context);
        }

        public void CreateHotel(HotelDTO hotelDTO)
        {
            var selectedAmenityIds = hotelDTO.AvailableAmenities.Select(x => int.Parse(x)).ToList();
            var selectedAmenities= amenityRepository.GetByRange(selectedAmenityIds);

            //var amenityDTOs = selectedAmenityIds.Select(amId => new AmenityDTO() { Key = amId }).ToList();



            //var amenities = AmenityMapper.MapDTOsToModelList(amenityDTOs);
            var tags = TagMapper.MapToModelList(hotelDTO.Tags);
            var rooms = RoomMapper.MapToModelList(hotelDTO.Rooms);

            var hotel = new Hotel(hotelDTO.LatinName, hotelDTO.NativeName, hotelDTO.District, selectedAmenities, hotelDTO.Location, hotelDTO.Description, rooms, hotelDTO.Rules, tags, hotelDTO.HotelGroupId);

            hotelRepository.Create(hotel);
        }

        public void DeleteHotel(int hotelId)
        {
            var hotel = hotelRepository.GetById(hotelId);

            hotelRepository.Delete(hotel);
        }

        public List<HotelDTO> GetAllHotels()
        {
            var hotels = hotelRepository.GetAll();

            return HotelMapper.MapToDTOs(hotels);
        }

        public HotelDTO GetHotelById(int id)
        {
            var hotel = hotelRepository.GetById(id);

            return HotelMapper.MapToDTO(hotel);
        }

        public void UpdateHotel(UpdateHotelDTO hotel)
        {
            var selectedHotel = hotelRepository.GetById(hotel.Id);
            var amenities = amenityRepository.GetByRange(hotel.AmenityIds);
            var tags = tagRepository.GetByRange(hotel.TagIds);
            var rooms = roomRepository.GetByRange(hotel.RoomIds);

            selectedHotel.Update(hotel.LatinName, hotel.NativeName, hotel.District, amenities, hotel.Location, hotel.Description, rooms, hotel.Rules, tags, hotel.HotelGroupId, hotel.IsDeleted);

            hotelRepository.Update();
        }
    }
}
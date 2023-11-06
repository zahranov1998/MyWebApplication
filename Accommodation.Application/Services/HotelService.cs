using Accommodation.Application.Contract.Hotels.DTO;
using Accommodation.Application.Contract.Hotels.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var selectedAmenities = amenityRepository.GetByRange(selectedAmenityIds);
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

        public void UpdateHotelDTO(HotelDTO hotel)
        {
            var selectedHotel = hotelRepository.GetById(hotel.Id);

            var amenityIds = new List<int>();

            foreach (var item in hotel.AvailableAmenities)
            {
                amenityIds.Add(Convert.ToInt32(item));
            }

            var selectedAmenities = amenityRepository.GetByRange(amenityIds);
            var tags = TagMapper.MapToModelList(hotel.Tags);
            var rooms = RoomMapper.MapToModelList(hotel.Rooms);

            selectedHotel.Update(hotel.LatinName, hotel.NativeName, hotel.District, selectedAmenities, hotel.Location, hotel.Description, rooms, hotel.Rules, tags, hotel.HotelGroupId, hotel.IsDeleted);

            hotelRepository.Update();
        }
    }
}
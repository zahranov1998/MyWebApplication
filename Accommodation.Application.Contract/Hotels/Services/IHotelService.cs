using Accommodation.Application.Contract.Hotels.DTO;
using System.Collections.Generic;

namespace Accommodation.Application.Contract.Hotels.Services
{
    public interface IHotelService
    {
        void CreateHotel(HotelDTO hotelDTO);

        HotelDTO GetHotelById(int hotelId);

        List<HotelDTO> GetAllHotels();

        void UpdateHotel(UpdateHotelDTO hotel);

        void DeleteHotel(int hotelId);
    }
}
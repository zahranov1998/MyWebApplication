using Accommodation.Application.Contract.Hotels.DTO;

namespace Accommodation.Application.Contract.Hotels.Services
{
    public interface IHotelService
    {
        void CreateHotel(HotelDTO hotelDTO);

        HotelDTO GetHotelById(int hotelId);
    }
}
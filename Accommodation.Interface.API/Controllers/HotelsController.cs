using Accommodation.Application.Contract.HotelGroups.Services;
using Accommodation.Application.Contract.Hotels.DTO;
using Accommodation.Application.Contract.Hotels.Services;
using Accommodation.Application.Services;
using System.Web.Http;

namespace Accommodation.Interface.API.Controllers
{
    public class HotelsController:ApiController
    {
        public readonly IHotelService hotelService;

        public HotelsController()
        {
            hotelService = new HotelService();
        }

        [HttpGet]
        public HotelDTO Get(int id)
        {
            return hotelService.GetHotelById(id);
        }

        [HttpPost]
        public void Post(HotelDTO hotel)
        {
            hotelService.CreateHotel(hotel);
        }
    }
}
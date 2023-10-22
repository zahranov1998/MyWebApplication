using Accommodation.Application.Contract.HotelGroups.DTO;
using Accommodation.Application.Contract.HotelGroups.Services;
using Accommodation.Application.Services;
using System.Web.Http;

namespace Accommodation.Interface.API.Controllers
{
    public class HotelGroupsController:ApiController
    {
        public readonly IHotelGroupService hotelGroupService;

        public HotelGroupsController()
        {
            hotelGroupService = new HotelGroupService();
        }

        [HttpGet]
        public HotelGroupDTO Get(int id)
        {
            return hotelGroupService.GetHotelGroupById(id);
        }

        [HttpPost]
        public void Post(HotelGroupDTO hotelGroupDTO)
        {
            hotelGroupService.CreateHotelGroup(hotelGroupDTO);
        }
    }
}
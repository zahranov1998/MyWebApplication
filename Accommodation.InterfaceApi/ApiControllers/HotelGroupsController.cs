using System.Collections.Generic;
using System.Web.Http;
using Accommodation.Application.Contract.HotelGroups.DTO;
using Accommodation.Application.Contract.HotelGroups.Services;
using Accommodation.Application.Services;

namespace Accommodation.InterfaceApi.ApiControllers
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

        [HttpGet]
        public List<HotelGroupDTO> GetALL()
        {
            return hotelGroupService.GetALLHotelGroups();
        }
    }
}
using System.Web.Http;
using Accommodation.Application.Contract.Rooms.DTO;
using Accommodation.Application.Contract.Rooms.Services;
using Accommodation.Application.Services;

namespace Accommodation.InterfaceApi.ApiControllers
{
    public class RoomsController:ApiController
    {
        public readonly IRoomService roomService;

        public RoomsController()
        {
            roomService = new RoomService();
        }

        [HttpGet]
        public RoomDTO Get(int id)
        {
            return roomService.GetRoomById(id);
        }
    }
}
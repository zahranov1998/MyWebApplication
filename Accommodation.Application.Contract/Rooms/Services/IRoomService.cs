using Accommodation.Application.Contract.Rooms.DTO;

namespace Accommodation.Application.Contract.Rooms.Services
{
    public interface IRoomService
    {
         RoomDTO GetRoomById(int roomId);
    }
}
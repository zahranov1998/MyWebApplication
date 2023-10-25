using Accommodation.Application.Contract.Rooms.DTO;
using System.Collections.Generic;

namespace Accommodation.Application.Contract.Rooms.Services
{
    public interface IRoomService
    {
        RoomDTO GetRoomById(int roomId);
    }
}
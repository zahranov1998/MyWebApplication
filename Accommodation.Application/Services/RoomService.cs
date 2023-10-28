using Accommodation.Application.Contract.Rooms.DTO;
using Accommodation.Application.Contract.Rooms.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;

namespace Accommodation.Application.Services
{
    public class RoomService : IRoomService
    {
        public readonly IRoomRepository RoomRepository;

        public RoomService()
        {
            var context = new AccommodationDbContext();

            RoomRepository = new RoomRepository(context);
        }

        public RoomDTO GetRoomById(int roomId)
        {
            var room = RoomRepository.GetById(roomId);

            return RoomMapper.MapToDTO(room);
        }
    }
}
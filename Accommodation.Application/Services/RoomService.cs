using Accommodation.Application.Contract.Rooms.DTO;
using Accommodation.Application.Contract.Rooms.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;
using System.Collections.Generic;

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

        //todo
        //public List<RoomDTO> GetAllRooms()
        //{
        //    var rooms = RoomRepository.GetAll();

        //    return RoomMapper.MapToDTOs(rooms);
        //}

        public RoomDTO GetRoomById(int roomId)
        {
            var room = RoomRepository.GetById(roomId);

            return RoomMapper.MapToDTO(room);
        }
    }
}
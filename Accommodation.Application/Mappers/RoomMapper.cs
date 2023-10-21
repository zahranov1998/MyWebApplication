using Accommodation.Application.Contract.Rooms.DTO;
using Accommodation.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.Application.Mappers
{
    public static class RoomMapper
    {
        public static RoomDTO MapToDTO(Room room)
        {
            return new RoomDTO()
            {
                Capacity = room.Capacity,
                CountOfBeds = room.CountOfBeds,
                HotelId = room.HotelId
            };
        }

        public static List<RoomDTO> MapToDTOs(List<Room> rooms)
        {
            return rooms.Select(r => MapToDTO(r)).ToList();
        }

        public static Room MapToModel(RoomDTO roomDTO)
        {
            return new Room(roomDTO.Capacity, roomDTO.CountOfBeds, roomDTO.HotelId);
        }

        public static List<Room> MapToModelList(List<RoomDTO> roomDTOs)
        {
            return roomDTOs.Select(r => MapToModel(r)).ToList();
        }
    }
}
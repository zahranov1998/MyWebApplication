using Accommodation.EF.Migration;
using HotelRepository.Models;
using HotelRepository.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.EF.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AccommodationDbContext _context;

        public RoomRepository(AccommodationDbContext context)
        {
            _context = context;
        }

        public List<Room> GetAll()
        {
            return _context.Rooms.ToList();
        }

        public Room GetById(int id)
        {
            return _context.Rooms.FirstOrDefault(r => r.Id == id);
        }
    }
}
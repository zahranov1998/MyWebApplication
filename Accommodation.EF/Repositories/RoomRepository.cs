using Accommodation.EF.Migration;
using HotelRepository.Models;
using HotelRepository.Repositories;
using System.Collections.Generic;

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
            throw new System.NotImplementedException();
        }

        public Room GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
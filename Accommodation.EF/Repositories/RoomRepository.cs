using Accommodation.EF.Migration;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
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

        public void Create(Room aggregate)
        {
            _context.Rooms.Add(aggregate);

            _context.SaveChanges();
        }

        public void Delete(Room aggregate)
        {
            _context.Rooms.Remove(aggregate);

            _context.SaveChanges();
        }

        public List<Room> GetAll()
        {
            return _context.Rooms.ToList();
        }

        public Room GetById(int id)
        {
            return _context.Rooms.FirstOrDefault(r => r.Id == id);
        }

        public List<Room> GetByRange(List<int> roomIds)
        {
            return _context.Rooms.Where(r=> roomIds.Contains(r.Id)).ToList();
        }

        public void Update()
        {
            _context.SaveChanges();
        }
    }
}
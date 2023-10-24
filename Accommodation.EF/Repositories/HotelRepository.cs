using Accommodation.EF.Migration;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Accommodation.EF.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly AccommodationDbContext _context;

        public HotelRepository(AccommodationDbContext context)
        {
            _context = context;
        }

        public List<Hotel> GetAll()
        {
            return _context.Hotels.Include(h => h.Amenities).Include(h=>h.Rooms).Include(h=>h.Tags).ToList();
        }

        public Hotel GetById(int id)
        {
            return _context.Hotels.Include(h=>h.Amenities).Include(h=>h.Rooms).Include(h=>h.Tags).FirstOrDefault(h => h.Id == id);
        }

        public void Create(Hotel aggregate)
        {
            _context.Hotels.Add(aggregate);

            _context.SaveChanges();
        }

        public void Delete(Hotel aggregate)
        {
            _context.Hotels.Remove(aggregate);

            _context.SaveChanges();
        }
    }
}
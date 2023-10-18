using Accommodation.EF.Migration;
using HotelRepository.Models;
using HotelRepository.Repositories;
using System.Collections.Generic;
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
            return _context.Hotels.ToList();
        }

        public Hotel GetById(int id)
        {
            return _context.Hotels.FirstOrDefault(h => h.Id == id);
        }
    }
}
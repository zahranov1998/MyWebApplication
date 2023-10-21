using Accommodation.EF.Migration;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
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

        public void AddHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);

            _context.SaveChanges();
        }

        public void Create(Hotel aggregate)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Hotel aggregate)
        {
            throw new System.NotImplementedException();
        }
    }
}
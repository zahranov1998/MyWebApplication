using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.EF.Repositories
{
    public class AmenityRepository : IAmenityRepository
    {
        private readonly AccommodationDbContext _context;

        public AmenityRepository(AccommodationDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Create(Amenity aggregate)
        {
            _context.Amenities.Add(aggregate);

            _context.SaveChanges();
        }

        public void Delete(Amenity aggregate)
        {
            _context.Amenities.Remove(aggregate);

            _context.SaveChanges();
        }

        public List<Amenity> GetAll()
        {
            return _context.Amenities.ToList();
        }

        public Amenity GetById(int id)
        {
            return _context.Amenities.FirstOrDefault(a => a.Id == id);
        }
    }
}

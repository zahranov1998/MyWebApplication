using Accommodation.EF.Migration;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.EF.Repositories
{
    public class AmenityRepository :IAmenityRepository
    {
        private readonly AccommodationDbContext _context;

        public AmenityRepository(AccommodationDbContext dbContext) 
        { 
            _context= dbContext;
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

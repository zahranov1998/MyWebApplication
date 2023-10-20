using Accommodation.EF.Migration;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.EF.Repositories
{
    public class CityRepository:ICityRepository
    {
        private readonly AccommodationDbContext _context;

        public CityRepository(AccommodationDbContext dbContext) 
        {
            _context= dbContext;
        }

        public List<City> GetAll()
        {
            return _context.Cities.ToList();
        }

        public City GetById(int id)
        {
            return _context.Cities.FirstOrDefault(c=>c.Id == id);
        }
    }
}
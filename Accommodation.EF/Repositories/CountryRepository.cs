
using Accommodation.EF.Migration;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.EF.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AccommodationDbContext _context;

        public CountryRepository(AccommodationDbContext dbContext)
        {
            _context= dbContext;
        }
        public List<Country> GetAll()
        {
            return _context.Countries.ToList();
        }

        public Country GetById(int id)
        {
            return _context.Countries.FirstOrDefault(c => c.Id == id);
        }
    }
}

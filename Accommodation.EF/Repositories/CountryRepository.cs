using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.EF.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AccommodationDbContext _context;

        public CountryRepository(AccommodationDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Create(Country aggregate)
        {
            _context.Countries.Add(aggregate);

            _context.SaveChanges();
        }

        public void Delete(Country aggregate)
        {
            _context.Countries.Remove(aggregate);

            _context.SaveChanges();
        }

        public List<Country> GetAll()
        {
            return _context.Countries.ToList();
        }

        public Country GetById(int id)
        {
            return _context.Countries.FirstOrDefault(c => c.Id == id);
        }

        public void Update()
        {
            _context.SaveChanges();
        }
    }
}
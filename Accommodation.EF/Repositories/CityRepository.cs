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

        public void Create(City aggregate)
        {
            _context.Cities.Add(aggregate);

            _context.SaveChanges();
        }

        public void Delete(City aggregate)
        {
            _context.Cities.Remove(aggregate);

            _context.SaveChanges();
        }

        public List<City> GetAll()
        {
            return _context.Cities.ToList();
        }

        public City GetById(int id)
        {
            return _context.Cities.FirstOrDefault(c=>c.Id == id);
        }

        public void Update()
        {
            _context.SaveChanges();
        }
    }
}
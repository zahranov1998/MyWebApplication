using Accommodation.EF.Migration;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Accommodation.EF.Repositories
{
    public class HotelGroupRepository : IHotelGroupRepository
    {
        private readonly AccommodationDbContext _context;

        public HotelGroupRepository(AccommodationDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Create(HotelGroup aggregate)
        {
            _context.HotelGroups.Add(aggregate);

            _context.SaveChanges();
        }

        public void Delete(HotelGroup aggregate)
        {
            _context.HotelGroups.Remove(aggregate);

            _context.SaveChanges();
        }

        public List<HotelGroup> GetAll()
        {
            return _context.HotelGroups.Include(h=>h.Hotels).ToList();
        }

        public HotelGroup GetById(int id)
        {
            return _context.HotelGroups.FirstOrDefault(h => h.Id == id);
        }

        public void Update()
        {
            _context.SaveChanges();
        }
    }
}
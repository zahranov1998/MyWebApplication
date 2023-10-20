using Accommodation.EF.Migration;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.EF.Repositories
{
    public class HotelGroupRepository : IHotelGroupRepository
    {
        private readonly AccommodationDbContext _context;

        public HotelGroupRepository(AccommodationDbContext dbContext)
        {
            _context = dbContext;
        }

        public List<HotelGroup> GetAll()
        {
            return _context.HotelGroups.ToList();
        }

        public HotelGroup GetById(int id)
        {
            return _context.HotelGroups.FirstOrDefault(h => h.Id == id);
        }
    }
}

using Accommodation.EF.Migration;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.EF.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly AccommodationDbContext _context;

        public TagRepository(AccommodationDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Create(Tag aggregate)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Tag aggregate)
        {
            throw new System.NotImplementedException();
        }

        public List<Tag> GetAll()
        {
            return _context.Tags.ToList();
        }

        public Tag GetById(int id)
        {
            return _context.Tags.FirstOrDefault(t => t.Id == id);
        }
    }
}
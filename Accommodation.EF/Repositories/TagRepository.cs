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
            _context.Tags.Add(aggregate);

            _context.SaveChanges();
        }

        public void Delete(Tag aggregate)
        {
            _context.Tags.Remove(aggregate);

            _context.SaveChanges();
        }

        public List<Tag> GetAll()
        {
            return _context.Tags.ToList();
        }

        public Tag GetById(int id)
        {
            return _context.Tags.FirstOrDefault(t => t.Id == id);
        }

        public List<Tag> GetByRange(List<int> tagIds)
        {
            return _context.Tags.Where(t=> tagIds.Contains(t.Id)).ToList();
        }

        public void Update()
        {
            _context.SaveChanges();
        }
    }
}
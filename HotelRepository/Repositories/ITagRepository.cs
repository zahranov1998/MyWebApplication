using Accommodation.Domain.Models;
using System.Collections.Generic;

namespace Accommodation.Domain.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
        List<Tag> GetByRange(List<int> tagIds);
    }
}
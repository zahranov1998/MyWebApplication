using Accommodation.Domain.Models;
using System.Collections.Generic;

namespace Accommodation.Domain.Repositories
{
    public interface IAmenityRepository : IRepository<Amenity>
    {

        List<Amenity> GetByRange(List<int> amenityIds);
    }
}
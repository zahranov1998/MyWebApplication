using Accommodation.Domain.Models;
using System.Collections.Generic;

namespace Accommodation.Domain.Repositories
{
    public interface IRoomRepository:IRepository<Room>
    {
        List<Room> GetByRange(List<int> roomIds);
    }
}
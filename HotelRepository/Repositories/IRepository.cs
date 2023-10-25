using System.Collections.Generic;

namespace Accommodation.Domain.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);

        List<T> GetAll();

        void Create(T aggregate);

        void Update();

        void Delete(T aggregate);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accommodation.Domain.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);

        List<T> GetAll();
    }
}
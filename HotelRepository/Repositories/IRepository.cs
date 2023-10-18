﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRepository.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);

        List<T> GetAll();
    }
}
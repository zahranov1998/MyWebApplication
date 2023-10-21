﻿using Accommodation.Application.Contract.Rooms.DTO;
using Accommodation.Application.Contract.Rooms.Services;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;
using System.Collections.Generic;

namespace Accommodation.Application.Services
{
    public class RoomServices:IRoomServices
    {
        public readonly IRoomRepository RoomRepository;

        public RoomServices()
        {
            var context = new AccommodationDbContext();

            RoomRepository = new RoomRepository(context);
        }
    }
}
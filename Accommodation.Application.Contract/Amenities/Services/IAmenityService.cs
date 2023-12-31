﻿using Accommodation.Application.Contract.Amenities.DTO;
using System.Collections.Generic;

namespace Accommodation.Application.Contract.Amenities.Services
{
    public interface IAmenityService
    {
        void CreateAmenity(CreateAmenityDTO amenity);

        void UpdateAmenity(UpdateAmenityDTO amenity);

        AmenityDTO GetAmenityById(int id);

        List<AmenityDTO> GetALLAmenities();

        void DeleteAmenity(int id);
    }
}
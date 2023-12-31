﻿using System.Collections.Generic;
using Accommodation.Application.Contract.Amenities.DTO;
using Accommodation.Application.Contract.Amenities.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;

namespace Accommodation.Application.Services
{
    public class AmenityService : IAmenityService
    {
        public readonly IAmenityRepository AmenityRepository;

        public AmenityService()
        {
            var context = new AccommodationDbContext();

            AmenityRepository = new AmenityRepository(context);
        }
        public void CreateAmenity(CreateAmenityDTO dto)
        {
            var amenity = new Amenity(dto.Title);

            AmenityRepository.Create(amenity);
        }

        public void UpdateAmenity(UpdateAmenityDTO amenity)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAmenity(int id)
        {
            var amenity = AmenityRepository.GetById(id);

            AmenityRepository.Delete(amenity);
        }

        public List<AmenityDTO> GetALLAmenities()
        {
            var amenities = AmenityRepository.GetAll();

            return AmenityMapper.MapToDTOs(amenities);
        }

        public AmenityDTO GetAmenityById(int id)
        {
            var amenity = AmenityRepository.GetById(id);

            return AmenityMapper.MapToDTO(amenity);
        }

        public void UpdateAmenity(AmenityDTO amenity)
        {
            var selectedAmenity = AmenityRepository.GetById(amenity.Key);

            selectedAmenity.Update(amenity.Title);

            AmenityRepository.Update();
        }
    }
}
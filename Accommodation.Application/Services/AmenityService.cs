using Accommodation.Application.Contract.Amenities.DTO;
using Accommodation.Application.Contract.Amenities.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;

namespace Accommodation.Application
{
    public class AmenityService : IAmenityService
    {
        public readonly IAmenityRepository AmenityRepository;

        public AmenityService()
        {
            var context = new AccommodationDbContext();

            AmenityRepository = new AmenityRepository(context);
        }
        public void CreateAmenity(AmenityDTO dto)
        {
            var amenity = new Amenity(dto.Title);

            AmenityRepository.Create(amenity);
        }

        public AmenityDTO GetAmenityById(int id)
        {
            var amenity = AmenityRepository.GetById(id);

            return AmenityMapper.MapToDTO(amenity);
        }
    }
}
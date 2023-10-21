using Accommodation.Application.Contract.Amenities.DTO;

namespace Accommodation.Application.Contract.Amenities.Services
{
    public interface IAmenityService
    {
        void CreateAmenity(AmenityDTO amenity);

        AmenityDTO GetAmenityById(int id);
    }
}
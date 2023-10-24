using Accommodation.Application.Contract.Amenities.DTO;
using Accommodation.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.Application.Mappers
{
    public static class AmenityMapper
    {
        public static AmenityDTO MapToDTO(Amenity amenity)
        {
            return new AmenityDTO() { Title = amenity.Title };
        }

        public static List<AmenityDTO> MapToDTOs(List<Amenity> amenities)
        {
                var a = amenities.Select(x => MapToDTO(x)).ToList();
            return a;
        }

        public static Amenity MapDTOToModel(AmenityDTO amenityDTO)
        {
            return new Amenity(amenityDTO.Title);
        }

        public static List<Amenity> MapDTOsToModelList(List<AmenityDTO> amenitieDTOs)
        {
            return amenitieDTOs.Select(a => MapDTOToModel(a)).ToList();
        }
    }
}
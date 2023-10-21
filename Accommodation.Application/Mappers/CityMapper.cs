using Accommodation.Application.Contract.Cities.DTO;
using Accommodation.Domain.Models;

namespace Accommodation.Application.Mappers
{
    public static class CityMapper
    {
        public static CityDTO MapToDTO(City city)
        {
            return new CityDTO() { CountryId = city.CountryId, Name = city.Name };
        }
    }
}
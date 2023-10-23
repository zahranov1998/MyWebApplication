using Accommodation.Application.Contract.Cities.DTO;
using Accommodation.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.Application.Mappers
{
    public static class CityMapper
    {
        public static CityDTO MapToDTO(City city)
        {
            return new CityDTO() { CountryId = city.CountryId, Name = city.Name };
        }

        public static List<CityDTO> MapToDTOs(List<City> cities)
        {
            return cities.Select(c=> MapToDTO(c)).ToList();
        }
    }
}
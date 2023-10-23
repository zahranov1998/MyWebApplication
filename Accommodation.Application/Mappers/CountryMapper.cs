using Accommodation.Application.Contract.Countries.DTO;
using Accommodation.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Accommodation.Application.Mappers
{
    public static class CountryMapper
    {
        public static CountryDTO MapToDTO(Country country)
        {
            return new CountryDTO() { Name = country.Name };
        }

        public static List<CountryDTO> MapToDTOs(List<Country> countries) 
        {
            return countries.Select(c=> MapToDTO(c)).ToList();
        }
    }
}
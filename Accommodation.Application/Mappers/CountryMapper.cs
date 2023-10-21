using Accommodation.Application.Contract.Countries.DTO;
using Accommodation.Domain.Models;

namespace Accommodation.Application.Mappers
{
    public static class CountryMapper
    {
        public static CountryDTO MapToDTO(Country country)
        {
            return new CountryDTO() { Name = country.Name };
        }
    }
}
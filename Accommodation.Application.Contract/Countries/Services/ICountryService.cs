using Accommodation.Application.Contract.Countries.DTO;
using System.Collections.Generic;

namespace Accommodation.Application.Contract.Countries.Services
{
    public interface ICountryService
    {
        void CreateCountry(CountryDTO countryDTO);

        CountryDTO GetCountryById(int countryId);

        List<CountryDTO> GetALLCountries();

        void UpdateCountry(UpdateCountryDTO country);
    }
}
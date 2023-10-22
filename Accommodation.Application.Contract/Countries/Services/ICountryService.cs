using Accommodation.Application.Contract.Countries.DTO;

namespace Accommodation.Application.Contract.Countries.Services
{
    public interface ICountryService
    {
        void CreateCountry(CountryDTO countryDTO);

        CountryDTO GetCountryById(int countryId);
    }
}
using Accommodation.Application.Contract.Countries.DTO;
using Accommodation.Application.Contract.Countries.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;
using System.Collections.Generic;

namespace Accommodation.Application.Services
{
    public class CountryService : ICountryService
    {
        public readonly ICountryRepository CountryRepository;

        public CountryService()
        {
            var context = new AccommodationDbContext();

            CountryRepository = new CountryRepository(context);
        }

        public void CreateCountry(CountryDTO countryDTO)
        {
            var country = new Country(countryDTO.Name);

            CountryRepository.Create(country);
        }

        public void DeleteCountry(int countryId)
        {
            var country = CountryRepository.GetById(countryId);

            CountryRepository.Delete(country);
        }

        public List<CountryDTO> GetALLCountries()
        {
            var countries = CountryRepository.GetAll();

            return CountryMapper.MapToDTOs(countries);
        }

        public CountryDTO GetCountryById(int id)
        {
            var country = CountryRepository.GetById(id);

            return CountryMapper.MapToDTO(country);
        }

        public void UpdateCountry(UpdateCountryDTO country)
        {
            var selectedCountry = CountryRepository.GetById(country.Id);

            selectedCountry.Update(country.Name);

            CountryRepository.Update();
        }
    }
}
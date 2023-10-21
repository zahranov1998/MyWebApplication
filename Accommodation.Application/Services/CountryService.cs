using Accommodation.Application.Contract.Countries.DTO;
using Accommodation.Application.Contract.Countries.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;

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

        public CountryDTO GetCountryById(int id)
        {
            var country = CountryRepository.GetById(id);

            return CountryMapper.MapToDTO(country);
        }
    }
}
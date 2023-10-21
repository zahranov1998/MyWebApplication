using Accommodation.Application.Contract.Cities.DTO;
using Accommodation.Application.Contract.Cities.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;

namespace Accommodation.Application.Services
{
    public class CityServices : ICityService
    {
        public readonly ICityRepository CityRepository;

        public CityServices()
        {
            var context = new AccommodationDbContext();

            CityRepository = new CityRepository(context);
        }

        public CityDTO GetCityById(int id)
        {
            var city = CityRepository.GetById(id);

            return CityMapper.MapToDTO(city);
        }
    }
}
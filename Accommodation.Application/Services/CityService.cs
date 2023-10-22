using Accommodation.Application.Contract.Cities.DTO;
using Accommodation.Application.Contract.Cities.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;

namespace Accommodation.Application.Services
{
    public class CityService : ICityService
    {
        public readonly ICityRepository CityRepository;

        public CityService()
        {
            var context = new AccommodationDbContext();

            CityRepository = new CityRepository(context);
        }

        public void CreateCity(CityDTO cityDTO)
        {
            var city = new City(cityDTO.Name, cityDTO.CountryId);

            CityRepository.Create(city);
        }

        public CityDTO GetCityById(int id)
        {
            var city = CityRepository.GetById(id);

            return CityMapper.MapToDTO(city);
        }
    }
}
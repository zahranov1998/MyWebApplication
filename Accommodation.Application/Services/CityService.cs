using Accommodation.Application.Contract.Cities.DTO;
using Accommodation.Application.Contract.Cities.Services;
using Accommodation.Application.Mappers;
using Accommodation.Domain.Models;
using Accommodation.Domain.Repositories;
using Accommodation.EF.Migration;
using Accommodation.EF.Repositories;
using System.Collections.Generic;

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

        public void DeleteCity(int cityId)
        {
            var city = CityRepository.GetById(cityId);

            CityRepository.Delete(city);
        }

        public List<CityDTO> GetALLCities()
        {
            var cities = CityRepository.GetAll();

            return CityMapper.MapToDTOs(cities);
        }

        public CityDTO GetCityById(int id)
        {
            var city = CityRepository.GetById(id);

            return CityMapper.MapToDTO(city);
        }

        public void UpdateCity(UpdateCityDTO city)
        {
            var SelectedCity = CityRepository.GetById(city.Id);

            SelectedCity.Update(city.Name, city.CountryId);

            CityRepository.Update();
        }
    }
}
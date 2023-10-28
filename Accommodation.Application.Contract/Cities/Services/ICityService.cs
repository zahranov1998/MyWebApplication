using Accommodation.Application.Contract.Cities.DTO;
using System.Collections.Generic;

namespace Accommodation.Application.Contract.Cities.Services
{
    public interface ICityService
    {
        void CreateCity(CityDTO cityDTO);

        CityDTO GetCityById(int cityId);

        List<CityDTO> GetALLCities();

        void UpdateCity(UpdateCityDTO city);

        void DeleteCity(int cityId);
    }
}
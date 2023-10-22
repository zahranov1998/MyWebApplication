using Accommodation.Application.Contract.Cities.DTO;

namespace Accommodation.Application.Contract.Cities.Services
{
    public interface ICityService
    {
        void CreateCity(CityDTO cityDTO);

        CityDTO GetCityById(int cityId);
    }
}
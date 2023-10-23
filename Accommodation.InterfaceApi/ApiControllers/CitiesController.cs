using System.Web.Http;
using Accommodation.Application.Contract.Cities.DTO;
using Accommodation.Application.Contract.Cities.Services;
using Accommodation.Application.Services;

namespace Accommodation.InterfaceApi.ApiControllers
{
    public class CitiesController:ApiController
    {
        public readonly ICityService cityService;

        public CitiesController()
        {
            cityService = new CityService();
        }

        [HttpGet]
        public CityDTO Get(int id)
        {
            return cityService.GetCityById(id);
        }

        [HttpPost]
        public void Post(CityDTO city)
        {
            cityService.CreateCity(city);
        }
    }
}
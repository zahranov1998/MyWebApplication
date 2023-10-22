using Accommodation.Application.Contract.Cities.DTO;
using Accommodation.Application.Contract.Cities.Services;
using Accommodation.Application.Services;
using System.Web.Http;

namespace Accommodation.Interface.API.Controllers
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
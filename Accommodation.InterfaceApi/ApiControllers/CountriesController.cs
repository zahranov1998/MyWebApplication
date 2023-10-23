using System.Web.Http;
using Accommodation.Application.Contract.Countries.DTO;
using Accommodation.Application.Contract.Countries.Services;
using Accommodation.Application.Services;

namespace Accommodation.InterfaceApi.ApiControllers
{
    public class CountriesController:ApiController
    {
        public readonly ICountryService countryService;

        public CountriesController()
        {
             countryService = new CountryService();
        }

        [HttpGet]
        public CountryDTO Get(int id)
        {
            return countryService.GetCountryById(id);
        }

        [HttpPost]
        public void Post(CountryDTO country)
        {
            countryService.CreateCountry(country);
        }
    }
}
﻿using System.Collections.Generic;
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

        [HttpGet]
        public List<CountryDTO> GetAll()
        {
            return countryService.GetALLCountries();
        }

        [HttpPut]
        public void Put(UpdateCountryDTO country)
        {
            countryService.UpdateCountry(country);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            countryService.DeleteCountry(id);
        }
    }
}
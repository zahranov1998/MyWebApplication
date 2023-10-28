using Accommodation.Application.Contract.Amenities.DTO;
using Accommodation.Application.Contract.Amenities.Services;
using Accommodation.Application.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Accommodation.InterfaceApi.ApiControllers
{
    public class AmenitiesController : ApiController
    {
        public readonly IAmenityService amenityService;

        public AmenitiesController()
        {
            amenityService = new AmenityService();
        }

        [HttpGet]
        public List<AmenityDTO> Get()
        {
            return amenityService.GetALLAmenities();
        }

        [HttpPost]
        public void Post(AmenityDTO amenityDTO)
        {
            amenityService.CreateAmenity(amenityDTO);
        }

        [HttpPut]
        public void Put(UpdateAmenityDTO amenityDTO)
        {
            amenityService.UpdateAmenity(amenityDTO);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            amenityService.DeleteAmenity(id);
        }
    }
}
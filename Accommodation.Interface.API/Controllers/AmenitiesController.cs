using Accommodation.Application;
using Accommodation.Application.Contract.Amenities.DTO;
using Accommodation.Application.Contract.Amenities.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Accommodation.Interface.API.Controllers
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
            return amenityService.GetAmenities();
        }

        [HttpPost]
        public void Post(AmenityDTO amenityDTO)
        {
            amenityService.CreateAmenity(amenityDTO);
        }
    }
}
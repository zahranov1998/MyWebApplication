using System.Web.Mvc;
using Accommodation.Application.Contract.Amenities.DTO;
using Accommodation.Application.Services;

namespace Accommodation.InterfaceApi.Controllers
{
    public class AmenitiesController : Controller
    {
        private readonly AmenityService _amenityService;

        public AmenitiesController()
        {
            _amenityService = new AmenityService();

        }

        public ActionResult Index()
        {
            var amenities = _amenityService.GetALLAmenities();
            var homeAmenity = new AmenityHomeDTO()
            {
                Amenities = amenities,
                NewAmenity = new CreateAmenityDTO()
            };

            return View(homeAmenity);
        }

        [HttpPost]
        public ActionResult Index(CreateAmenityDTO amenity)
        {
            _amenityService.CreateAmenity(amenity);

            return RedirectToAction("Index");
        }
    }
}
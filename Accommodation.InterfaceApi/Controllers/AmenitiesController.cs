using System.Web.Mvc;
using Accommodation.Application.Services;

namespace Accommodation.InterfaceApi.Controllers
{
    public class AmenitiesController : Controller
    {
        public ActionResult GetAmenities()
        {
            AmenityService amenityService = new AmenityService();
            var amenities = amenityService.GetALLAmenities();

            return View(amenities);
        }
    }
}
using Accommodation.Application.Contract.Hotels.DTO;
using Accommodation.Application.Services;
using System.Web.Mvc;
using Accommodation.Application.Contract.ViewModels;

namespace Accommodation.InterfaceApi.Controllers
{
    public class HotelsController : Controller
    {
        private readonly HotelService _hotelService;
        private readonly AmenityService _amenityService;

        public HotelsController()
        {
            this._hotelService = new HotelService();
            _amenityService = new AmenityService();
        }

        public ActionResult Index()
        {
            var model = _hotelService.GetAllHotels();

            return View(model);
        }

        public ActionResult AddHotel()
        {
            var amenities = _amenityService.GetALLAmenities();
            var modifyHotel = new ModifyHotelViewModel()
            {
                Amenities = amenities,
                Hotel = new HotelDTO()
            };

            return View(modifyHotel);
        }

        [HttpPost]
        public ActionResult AddHotel([Bind(Prefix = "Hotel")] HotelDTO hotelDTO)
        {
            _hotelService.CreateHotel(hotelDTO);

            return RedirectToAction("Index");
        }
        //public ActionResult Edit(int id)
        //{
        //    var service = new HotelService();

        //    var model = service.GetAllHotels();
        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult Edit()
        //{
        //    var service = new HotelService();

        //    var model = service.GetAllHotels();
        //    return View(model);
        //}
    }
}
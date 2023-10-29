using Accommodation.Application.Contract.Hotels.DTO;
using Accommodation.Application.Services;
using System.Web.Mvc;

namespace Accommodation.InterfaceApi.Controllers
{
    public class HotelsController : Controller
    {
        private readonly HotelService _hotelService;

        public HotelsController()
        {
            this._hotelService = new HotelService();
        }

        public ActionResult Index()
        {
            var model = _hotelService.GetAllHotels();

            return View(model);
        }

        public ActionResult AddHotel()
        
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHotel(HotelDTO hotelDTO)
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
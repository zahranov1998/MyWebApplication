using Accommodation.Application.Services;
using System.Web.Mvc;

namespace Accommodation.InterfaceApi.Controllers
{
    public class HotelsController : Controller
    {
        public ActionResult Index()
        {
            var service = new HotelService();

            var model = service.GetAllHotels();
            return View(model);
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
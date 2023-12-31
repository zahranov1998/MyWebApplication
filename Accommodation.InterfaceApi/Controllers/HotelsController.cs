﻿using System.Collections.Generic;
using Accommodation.Application.Contract.Hotels.DTO;
using Accommodation.Application.Services;
using System.Web.Mvc;
using Accommodation.Application.Contract.Amenities.DTO;
using Accommodation.Application.Contract.ViewModels;

namespace Accommodation.InterfaceApi.Controllers
{
    public class HotelsController : Controller
    {
        private readonly HotelService _hotelService;
        private readonly AmenityService _amenityService;
        private readonly HotelGroupService _hotelGroupService;

        public HotelsController()
        {
            this._hotelService = new HotelService();
            _amenityService = new AmenityService();
            _hotelGroupService = new HotelGroupService();
        }

        public ActionResult Index()
        {
            var model = _hotelService.GetAllHotels();

            return View(model);
        }

        public ActionResult AddHotel()
        {
            var amenities = _amenityService.GetALLAmenities();
            var amenityCheckboxes = new List<AmenityCheckbox>();
            var hotelGroups = _hotelGroupService.GetALLHotelGroups();

            foreach (var amenityDto in amenities)
            {
                amenityCheckboxes.Add(new AmenityCheckbox(){Name = amenityDto.Title,Value = amenityDto.Title,Checked = false});
            }

            var modifyHotel = new AddHotelViewModel()
            {
                Amenities = amenities,
                HotelGroups = hotelGroups,
                Hotel = new HotelDTO(),
                AmenityCheckboxes = amenityCheckboxes
            };

            return View(modifyHotel);
        }

        [HttpPost]
        public ActionResult AddHotel(AddHotelViewModel addHotel)
        {
            addHotel.Hotel.Amenities = new List<AmenityDTO>();


            _hotelService.CreateHotel(addHotel.Hotel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var hotel =_hotelService.GetHotelById(id);

            return View(hotel);
        }


        public ActionResult Edit(int id)
        {
            var hotel = _hotelService.GetHotelById(id);
            hotel.AllAmenities = _amenityService.GetALLAmenities();

            return View(hotel);
        }

        [HttpPost]
        public ActionResult Edit(HotelDTO hotel)
        {
            _hotelService.UpdateHotelDTO(hotel);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _hotelService.DeleteHotel(id);

            return RedirectToAction("Index");
        }
    }
}
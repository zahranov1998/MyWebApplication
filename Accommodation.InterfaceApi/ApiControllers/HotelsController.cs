﻿using System.Web.Http;
using Accommodation.Application.Contract.Hotels.DTO;
using Accommodation.Application.Contract.Hotels.Services;
using Accommodation.Application.Services;

namespace Accommodation.InterfaceApi.ApiControllers
{
    public class HotelsController:ApiController
    {
        public readonly IHotelService hotelService;

        public HotelsController()
        {
            hotelService = new HotelService();
        }

        [HttpGet]
        public HotelDTO Get(int id)
        {
            return hotelService.GetHotelById(id);
        }

        [HttpPost]
        public void Post(HotelDTO hotel)
        {
            hotelService.CreateHotel(hotel);
        }
    }
}
using Accommodation.Application.Contract.Hotels.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accommodation.InterfaceApi.ViewModels
{
    public class HotelListViewModel
    {
        public List<HotelDTO> Hotels{ get; set; }
    }
}
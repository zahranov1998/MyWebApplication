using Accommodation.Application.Contract.Hotels.DTO;
using System.Collections.Generic;

namespace Accommodation.InterfaceApi.ViewModels
{
    public class HotelListViewModel
    {
        public List<HotelDTO> Hotels { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accommodation.Application.Contract.Amenities.DTO;
using Accommodation.Application.Contract.Hotels.DTO;

namespace Accommodation.Application.Contract.ViewModels
{
    public class ModifyHotelViewModel
    {
        public List<AmenityDTO> Amenities { get; set; }

        public HotelDTO Hotel { get; set; }
    }
}

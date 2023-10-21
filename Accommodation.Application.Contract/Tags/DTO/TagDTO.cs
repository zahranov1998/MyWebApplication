using Accommodation.Application.Contract.Hotels.DTO;
using System.Collections.Generic;

namespace Accommodation.Application.Contract.Tags.DTO
{
    public class TagDTO
    {
        public string Title { get; set; }

        public List<HotelDTO> hotels { get; set; }
    }
}
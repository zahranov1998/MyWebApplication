using System.Collections.Generic;

namespace Accommodation.Domain.Models
{
    public class HotelGroup
    {
        public int Id { get; set; }

        public string LatinTitle { get; set; }

        public string NativeTitle { get; set; }

        public City City { get; set; }

        public int CityId { get; set; }

        public List<Hotel> Hotels { get; set; }
    }
}
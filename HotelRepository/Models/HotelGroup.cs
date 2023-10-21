using System.Collections.Generic;

namespace Accommodation.Domain.Models
{
    public class HotelGroup
    {
        public int Id { get;private set; }

        public string LatinTitle { get; private set; }

        public string NativeTitle { get; private set; }

        public City City { get; private set; }

        public int CityId { get; private set; }

        public List<Hotel> Hotels { get; private set; }

        private HotelGroup()
        {
                
        }

        public HotelGroup(string latinTitle , string nativeTitle , int cityId)
        {
            LatinTitle = latinTitle;
            NativeTitle = nativeTitle;
            CityId = cityId;
        }
    }
}
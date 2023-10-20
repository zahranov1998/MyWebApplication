using System.Collections.Generic;

namespace Accommodation.Domain.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        public string LatinName { get; set; }

        public string NativeName { get; set; }

        public string District { get; set; }

        public List<Amenity> Amenities { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public List<Room> Rooms { get; set; }

        public string Rules { get; set; }

        public List<Tag> Tags { get; set; }

        public HotelGroup HotelGroup { get; set; }

        public int HotelGroupId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
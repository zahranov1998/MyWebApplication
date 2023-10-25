using System.Collections.Generic;

namespace Accommodation.Domain.Models
{
    public class Hotel
    {
        public int Id { get;private set; }

        public string LatinName { get; private set; }

        public string NativeName { get; private set; }

        public string District { get; private set; }

        public List<Amenity> Amenities { get; private set; }

        public string Location { get; private set; }

        public string Description { get; private set; }

        public List<Room> Rooms { get; private set; }

        public string Rules { get; private set; }

        public List<Tag> Tags { get; private set; }

        public HotelGroup HotelGroup { get; private set; }

        public int HotelGroupId { get; private set; }

        public bool IsDeleted { get; private set; }

        private Hotel()
        {
                
        }

        public Hotel(string latinName, string nativeName, string district, List<Amenity> amenities, string location, string description, List<Room> rooms, string rules, List<Tag> tags, int hotelGroupId)
        {
            LatinName = latinName;
            NativeName = nativeName;
            District = district;
            Amenities = amenities;
            Location = location;
            Description = description;
            Rooms = rooms;
            Rules = rules;
            Tags = tags;
            HotelGroupId = hotelGroupId;
            IsDeleted = false;
        }


        public void Delete()
        {
            IsDeleted = true;
        }

        public void Update(string latinName, string nativeName, string district, List<Amenity> amenities, string location, string description, List<Room> rooms, string rules, List<Tag> tags, int hotelGroupId , bool isDeleted)
        {
            LatinName = latinName;
            NativeName = nativeName;
            District = district;
            Amenities = amenities;
            Location = location;
            Description = description;
            Rooms = rooms;
            Rules = rules;
            Tags = tags;
            HotelGroupId = hotelGroupId;
            IsDeleted = isDeleted;
        }
    }
}
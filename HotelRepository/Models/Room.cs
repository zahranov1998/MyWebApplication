namespace Accommodation.Domain.Models
{
    public class Room
    {
        public int Id { get;private set; }

        public int Capacity { get; private set; }

        public int CountOfBeds { get; private set; }

        public Hotel Hotel { get; private set; }

        public int HotelId { get; private set; }

        private Room()
        {
            
        }

        public Room(int capacity , int countOfBeds , int hotelId)
        {
            Capacity = capacity;
            CountOfBeds = countOfBeds;
            HotelId = hotelId;
        }
    }
}
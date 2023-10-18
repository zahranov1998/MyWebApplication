namespace HotelRepository.Models
{
    public class Room
    {
        public int Id { get; set; }

        public int Capacity { get; set; }

        public int CountOfBeds { get; set; }

        public Hotel Hotel { get; set; }

        public int HotelId { get; set; }
    }
}
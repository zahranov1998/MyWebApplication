namespace Accommodation.Application.Contract.Rooms.DTO
{
    public class UpdateRoomDTO
    {
        public int Id { get; set; }

        public int Capacity { get; set; }

        public int CountOfBeds { get; set; }

        public int HotelId { get; set; }
    }
}

namespace Accommodation.Application.Contract.Amenities.DTO
{
    public class AmenityDTO
    {
        public string Title { get; set; }
        public int Key { get; set; }
    }

    public class AmenityCheckbox
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Checked { get; set; }
    }
}
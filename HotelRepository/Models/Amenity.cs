using System.Collections.Generic;

namespace Accommodation.Domain.Models
{
    public class Amenity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<Hotel> Hotels { get; set; }
    }
}
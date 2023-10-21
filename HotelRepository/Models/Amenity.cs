using System.Collections.Generic;

namespace Accommodation.Domain.Models
{
    public class Amenity
    {
        public int Id { get;private  set; }

        public string Title { get; private set; }     

        public List<Hotel> Hotels { get;private set; }

        private Amenity()
        {

        }

        public Amenity(string title)
        {
            Title = title;
        }
    }
}
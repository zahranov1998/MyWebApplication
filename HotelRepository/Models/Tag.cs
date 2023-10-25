using System.Collections.Generic;
using System.Reflection;

namespace Accommodation.Domain.Models
{
    public class Tag
    {
        public int Id { get;private set; }

        public string Title { get; private set; }

        public List<Hotel> Hotels { get;private set; }

        private Tag()
        {
             
        }

        public Tag(string title)
        {
            Title = title;
        }

        public void Update(string title)
        {
            Title = title;
        }
    }
}
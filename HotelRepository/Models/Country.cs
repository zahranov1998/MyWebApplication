using System.Collections.Generic;

namespace Accommodation.Domain.Models
{
    public class Country
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public List<City> Cities { get; private set; }

        private Country()
        {

        }

        public Country(string name)
        {
             Name = name;
        }

    }
}
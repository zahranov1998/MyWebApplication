namespace Accommodation.Domain.Models
{
    public class City
    {
        public int Id { get;private set; }

        public string Name { get;private set; }

        public Country Country { get; private set; }

        public int CountryId { get; private set; }

        private City()
        {
                
        }

        public City(string name , int countryId)
        {
            Name = name;

            CountryId = countryId;
        }
    }
}
using Accommodation.InterfaceApi.ApiControllers;

namespace Accommodation.InterfaceApi.ViewModels
{
    public class HotelDTO1
    {
        public string NativeName { get; set; }

        public string LatinName { get; set; }

        public string District { get; set; }

        public string CityName { get; set; }

        public string CityLatinName { get; set; }

        public string CountryName { get; set; }

        public int CountOfSingleRoom { get; set; }

        public int CountOfDoubleRoom { get; set; }

        public int CountOfTripleRoom { get; set; }

        //Amenities??

        public string Description { get; set; }

        public  string Rules { get; set; }
    }
}
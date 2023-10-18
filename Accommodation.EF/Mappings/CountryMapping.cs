using HotelRepository.Models;
using System.Data.Entity.ModelConfiguration;

namespace Accommodation.EF.Mappings
{
    public class CountryMapping : EntityTypeConfiguration<Country>
    {
        public CountryMapping()
        {
            ToTable("Countries");

            Property(c => c.Id).IsRequired();
            Property(c => c.Name).IsRequired();

            HasMany(c => c.Cities).WithRequired(c => c.Country);
        }
    }
}
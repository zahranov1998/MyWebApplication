using HotelRepository.Models;
using System.Data.Entity.ModelConfiguration;

namespace Accommodation.EF.Mappings
{
    public class AmenityMapping : EntityTypeConfiguration<Amenity>
    {
        public AmenityMapping()
        {
            ToTable("Amenities");

            Property(a => a.Id).IsRequired();
            Property(a => a.Title).IsRequired();

            HasMany(x => x.Hotels).WithMany(x => x.Amenities).Map(z =>
            {
                z.MapRightKey("AmenityId");
                z.MapLeftKey("HotelId");
                z.ToTable("HotelAmenities");
            });
        }
    }
}
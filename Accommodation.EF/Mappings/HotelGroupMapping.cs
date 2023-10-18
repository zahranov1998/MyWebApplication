using HotelRepository.Models;
using System.Data.Entity.ModelConfiguration;

namespace Accommodation.EF.Mappings
{
    public class HotelGroupMapping : EntityTypeConfiguration<HotelGroup>
    {
        public HotelGroupMapping()
        {
            Property(h => h.Id).IsRequired();
            Property(h => h.NativeTitle).IsRequired();
            Property(h => h.LatinTitle).IsRequired();

            HasRequired(h => h.City).WithMany().HasForeignKey(c=>c.CityId);

            HasMany(h => h.Hotels).WithRequired(h => h.HotelGroup).HasForeignKey(h => h.HotelGroupId);
        }
    }
}
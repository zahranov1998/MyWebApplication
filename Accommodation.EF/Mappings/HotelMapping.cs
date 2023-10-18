using HotelRepository.Models;
using System.Data.Entity.ModelConfiguration;

namespace Accommodation.EF.Mappings
{
    public class HotelMapping : EntityTypeConfiguration<Hotel>
    {
        public HotelMapping()
        {
            Property(h => h.Id).IsRequired();
            Property(h => h.LatinName).IsRequired();
            Property(h => h.NativeName).IsRequired();
            Property(h => h.Location).IsOptional();
            Property(h => h.Rules).IsOptional();
            Property(h => h.IsDeleted).IsRequired();
            Property(h => h.Description).IsOptional();
            Property(h=>h.District).IsOptional();

            HasMany(h => h.Rooms).WithRequired(r => r.Hotel).HasForeignKey(c=>c.HotelId);

            HasMany(h => h.Tags).WithMany(t => t.Hotels).Map(t =>
            {
                t.MapLeftKey("TagId");
                t.MapRightKey("HotelId");
                t.ToTable("HotelTags");
            });
        }
    }
}
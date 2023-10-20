using Accommodation.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace Accommodation.EF.Mappings
{
    public class RoomMapping : EntityTypeConfiguration<Room>
    {
        public RoomMapping()
        {
            Property(r => r.Id).IsRequired();

            HasRequired(c=>c.Hotel).WithMany(c=>c.Rooms).HasForeignKey(c=>c.HotelId);
        }
    }
}
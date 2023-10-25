using Accommodation.Domain.Models;
using Accommodation.EF.Mappings;
using System.Data.Entity;

namespace Accommodation.EF.Migration
{
    public class AccommodationDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Amenity> Amenities { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<HotelGroup> HotelGroups { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public AccommodationDbContext() : base("DbConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.AddFromAssembly(typeof(CityMapping).Assembly);
        }
    }
}
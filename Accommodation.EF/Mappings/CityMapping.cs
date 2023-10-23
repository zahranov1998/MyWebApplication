using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Accommodation.Domain.Models;

namespace Accommodation.EF.Mappings
{
    public class CityMapping : EntityTypeConfiguration<City>
    {
        public CityMapping()
        {
            ToTable("Cities").HasKey(a => a.Id).Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Id).IsRequired();
            Property(a => a.Name).IsRequired();
        }
    }
}
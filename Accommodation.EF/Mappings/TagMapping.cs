using Accommodation.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace Accommodation.EF.Mappings
{
    public class TagMapping:EntityTypeConfiguration<Tag>
    {
        public TagMapping()
        {
            Property(t => t.Id).IsRequired();
            Property(t=>t.Title).IsRequired();
        }
    }
}

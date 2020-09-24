using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ApplicationTypeMap : IEntityTypeConfiguration<ApplicationType>
    {
        public void Configure(EntityTypeBuilder<ApplicationType> builder)
        {
            builder.HasKey(t => t.ApplicationTypeId);

            builder.ToTable("ApplicationType");

            builder.Property(t => t.ApplicationTypeId).HasColumnName("ApplicationTypeId");
            builder.Property(t => t.Name).HasColumnName("Name");
        }
    }
}

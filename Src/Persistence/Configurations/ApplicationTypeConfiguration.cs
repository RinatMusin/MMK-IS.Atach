using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
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

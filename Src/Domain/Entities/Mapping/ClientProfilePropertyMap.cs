using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ClientProfilePropertyMap : IEntityTypeConfiguration<ClientProfileProperty>
    {
        public void Configure(EntityTypeBuilder<ClientProfileProperty> builder)
        {
            builder.HasKey(t => t.ClientProfilePropertyId);

            builder.ToTable("ClientProfile_Property");

            builder.Property(t => t.ClientProfileId).HasColumnName("ClientProfileId");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Value).HasColumnName("Value");

            builder.HasRequired(t => t.ClientProfile)
                .WithMany(t => t.ClientProfileProperties)
                .HasForeignKey(t => t.ClientProfilePropertyId)
                .WillCascadeOnDelete(true);

        }
    }
}

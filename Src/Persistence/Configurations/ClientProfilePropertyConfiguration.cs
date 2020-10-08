using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ClientProfilePropertyConfiguration : IEntityTypeConfiguration<ClientProfileProperty>
    {
        public void Configure(EntityTypeBuilder<ClientProfileProperty> builder)
        {
            builder.HasKey(t => t.ClientProfilePropertyId);

            builder.ToTable("ClientProfileProperties");

            builder.Property(t => t.ClientProfileId).HasColumnName("ClientProfileId");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Value).HasColumnName("Value");

            builder.HasOne(t => t.ClientProfile).WithOne().IsRequired();
            builder.HasOne(t => t.ClientProfile)
                .WithMany(t => t.ClientProfileProperties)
                .HasForeignKey(t => t.ClientProfilePropertyId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}

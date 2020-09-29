using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ComponentPropertyMap : IEntityTypeConfiguration<ComponentProperty>
    {
        public void Configure(EntityTypeBuilder<ComponentProperty> builder)
        {
            builder.ToTable("ComponentProperty");

            builder.HasKey(t => t.ComponentPropertyId);

            builder.Property(t => t.ComponentId).HasColumnName("ComponentId");
            builder.Property(t => t.Key).HasColumnName("Key").HasColumnType("varchar");
            builder.Property(t => t.Value).HasColumnName("Value").HasColumnType("varchar");

            builder.Property(t => t.Component).IsRequired();
            builder.HasOne(t => t.Component)
                .WithMany(t => t.ComponentProperties)
                .HasForeignKey(t => t.ComponentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

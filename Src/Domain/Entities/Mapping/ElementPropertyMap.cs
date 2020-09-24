using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ElementPropertyMap : IEntityTypeConfiguration<ElementProperty>
    {
        public void Configure(EntityTypeBuilder<ElementProperty> builder)
        {
            builder.ToTable("ElementProperty");

            builder.HasKey(t => t.ElementPropertyId);

            builder.Property(t => t.ElementId).HasColumnName("ElementId");
            builder.Property(t => t.Key).HasColumnName("Key").HasColumnType("varchar");
            builder.Property(t => t.Value).HasColumnName("Value").HasColumnType("varchar");

            builder.HasRequired(t => t.Element)
                .WithMany(t => t.ElementProperties)
                .HasForeignKey(d => d.ElementId)
                .WillCascadeOnDelete(true);
        }
    }
}

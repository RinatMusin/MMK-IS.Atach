using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ElementDefaultValueMap : IEntityTypeConfiguration<ElementDefaultValue>
    {
        public void Configure(EntityTypeBuilder<ElementDefaultValue> builder)
        {
            builder.ToTable("ElementDefaultValue");

            builder.HasKey(t => t.ElementDefaultValueId);

            builder.Property(t => t.ElementId).HasColumnName("ElementId");
            builder.Property(t => t.Value).HasColumnName("Value").HasColumnType("varchar");
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");

            builder.HasRequired(t => t.Element)
                .WithMany(t => t.ElementDefaultValues)
                .HasForeignKey(d => d.ElementId)
                .WillCascadeOnDelete(true);
        }
    }
}

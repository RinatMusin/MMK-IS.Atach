using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ElementDefaultValueConfiguration : IEntityTypeConfiguration<ElementDefaultValue>
    {
        public void Configure(EntityTypeBuilder<ElementDefaultValue> builder)
        {
            builder.ToTable("ElementDefaultValue");

            builder.HasKey(t => t.ElementDefaultValueId);

            builder.Property(t => t.ElementId).HasColumnName("ElementId");
            builder.Property(t => t.Value).HasColumnName("Value").HasMaxLength(8000);
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");

            builder.HasOne(t => t.Element).WithOne().IsRequired();
            builder.HasOne(t => t.Element)
                .WithMany(t => t.ElementDefaultValues)
                .HasForeignKey(d => d.ElementId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ComponentElementConfiguration : IEntityTypeConfiguration<ComponentElement>
    {
        public void Configure(EntityTypeBuilder<ComponentElement> builder)
        {
            builder.ToTable("ComponentElement");

            builder.HasKey(t => t.ComponentElementId);

            builder.Property(t => t.ComponentId).HasColumnName("ComponentId");
            builder.Property(t => t.ElementId).HasColumnName("ElementId");

            builder.HasOne(t => t.Component).WithOne().IsRequired();
            builder.HasOne(t => t.Component)
                .WithMany(t => t.ComponentElements)
                .HasForeignKey(t => t.ComponentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Element).WithOne().IsRequired();
            builder.HasOne(t => t.Element)
                .WithMany(t => t.ComponentElements)
                .HasForeignKey(t => t.ElementId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

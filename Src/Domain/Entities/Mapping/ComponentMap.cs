using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ComponentMap : IEntityTypeConfiguration<Component>
    {
        public void Configure(EntityTypeBuilder<Component> builder)
        {
            builder.ToTable("Component");

            builder.HasKey(t => t.ComponentId);

            builder.Property(t => t.ViewPanelId).HasColumnName("ViewPanelId");
            builder.Property(t => t.SystemName).HasColumnName("SystemName").HasColumnType("varchar");
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");

            builder.HasRequired(t => t.ViewPanel)
                .WithMany(t => t.Components)
                .HasForeignKey(t => t.ViewPanelId)
                .WillCascadeOnDelete(true);
        }
    }
}

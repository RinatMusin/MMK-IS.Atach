using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ViewPanelMap : IEntityTypeConfiguration<ViewPanel>
    {
        public void Configure(EntityTypeBuilder<ViewPanel> builder)
        {
            builder.ToTable("ViewPanel");

            builder.HasKey(t => t.ViewPanelId);

            builder.Property(t => t.SystemName).HasColumnName("SystemName").HasColumnType("varchar");
        }
    }
}

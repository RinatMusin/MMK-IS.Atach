using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ViewPanelConfiguration : IEntityTypeConfiguration<ViewPanel>
    {
        public void Configure(EntityTypeBuilder<ViewPanel> builder)
        {
            builder.ToTable("ViewPanel");

            builder.HasKey(t => t.ViewPanelId);

            builder.Property(t => t.SystemName).HasColumnName("SystemName").HasMaxLength(8000);
        }
    }
}

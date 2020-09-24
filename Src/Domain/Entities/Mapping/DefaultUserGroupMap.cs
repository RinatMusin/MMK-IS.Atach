using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class DefaultUserSettingsMap : IEntityTypeConfiguration<DefaultUserSettings>
    {
        public void Configure(EntityTypeBuilder<DefaultUserSettings> builder)
        {
            builder.ToTable("DefaultUserSettings");

            builder.HasKey(t => t.DefaultUserSettingsId);

            builder.Property(t => t.ElementId).HasColumnName("ElementId");
            builder.Property(t => t.Value).HasColumnName("Value").HasColumnType("varchar");
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");

            builder.HasRequired(t => t.Element)
                .WithMany(t => t.DefaultUserSettings)
                .HasForeignKey(d => d.ElementId)
                .WillCascadeOnDelete(true);
        }
    }
}

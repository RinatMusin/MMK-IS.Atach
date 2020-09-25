using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class UserSettingsMap : IEntityTypeConfiguration<UserSettings>
    {
        public void Configure(EntityTypeBuilder<UserSettings> builder)
        {
            builder.ToTable("UserSettings");

            builder.HasKey(t => t.UserSettingsId);

            builder.Property(t => t.ElementId).HasColumnName("ElementId");
            builder.Property(t => t.ClientProfileId).HasColumnName("ClientProfileId");
            builder.Property(t => t.Value).HasColumnName("Value").HasColumnType("varchar");
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");

            builder.HasRequired(t => t.Element)
                .WithMany(t => t.UserSettings)
                .HasForeignKey(d => d.ElementId)
                .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.ClientProfile)
                .WithMany()
                .HasForeignKey(d => d.ClientProfileId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

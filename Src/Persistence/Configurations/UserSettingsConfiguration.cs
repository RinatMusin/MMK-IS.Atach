using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class UserSettingsConfiguration : IEntityTypeConfiguration<UserSettings>
    {
        public void Configure(EntityTypeBuilder<UserSettings> builder)
        {
            builder.ToTable("UserSettings");

            builder.HasKey(t => t.UserSettingsId);

            builder.Property(t => t.ElementId).HasColumnName("ElementId");
            builder.Property(t => t.ClientProfileId).HasColumnName("ClientProfileId");
            builder.Property(t => t.Value).HasColumnName("Value").HasMaxLength(8000);
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");

            builder.HasOne(t => t.Element).WithOne().IsRequired();
            builder.HasOne(t => t.Element).WithMany(t => t.UserSettings).HasForeignKey(t => t.ElementId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.ClientProfile).WithOne().IsRequired();
            builder.HasOne(t => t.ClientProfile).WithMany().HasForeignKey(t => t.ClientProfileId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}

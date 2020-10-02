using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class DefaultUserSettingsConfiguration : IEntityTypeConfiguration<DefaultUserSettings>
    {
        public void Configure(EntityTypeBuilder<DefaultUserSettings> builder)
        {
            builder.ToTable("DefaultUserSettings");

            builder.HasKey(t => t.DefaultUserSettingsId);

            builder.Property(t => t.ElementId).HasColumnName("ElementId");
            builder.Property(t => t.Value).HasColumnName("Value").HasColumnType("varchar");
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");


            builder.HasOne(t => t.Element).WithOne().IsRequired();
            builder.HasOne(t => t.Element)
                .WithMany(t => t.DefaultUserSettings)
                .HasForeignKey(d => d.ElementId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

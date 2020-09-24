using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ActivityPropertyMap : IEntityTypeConfiguration<ActivityProperty>
    {
        public void Configure(EntityTypeBuilder<ActivityProperty> builder)
        {
            builder.HasKey(t => t.ActivityPropertyId);

            builder.ToTable("Activity_Property");

            builder.Property(t => t.ActivityId).HasColumnName("ActivityId");
            builder.Property(t => t.Key).HasColumnName("Key");
            builder.Property(t => t.Value).HasColumnName("Value");

            builder.HasRequired(t => t.Activity)
                .WithMany(t => t.ActivityProperties)
                .HasForeignKey(t => t.ActivityId);

        }

    }
}

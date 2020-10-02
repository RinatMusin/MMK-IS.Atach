using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ActivityPropertyConfiguration : IEntityTypeConfiguration<ActivityProperty>
    {
        public void Configure(EntityTypeBuilder<ActivityProperty> builder)
        {
            builder.HasKey(t => t.ActivityPropertyId);

            builder.ToTable("Activity_Property");

            builder.Property(t => t.ActivityId).HasColumnName("ActivityId");
            builder.Property(t => t.Key).HasColumnName("Key");
            builder.Property(t => t.Value).HasColumnName("Value");


            builder.HasOne(t => t.Activity).WithOne().IsRequired();
            //.HasRequired(t => t.Activity)
            builder.HasOne(t => t.Activity).WithMany(t => t.ActivityProperties).HasForeignKey(t => t.ActivityId);
                

        }

    }
}

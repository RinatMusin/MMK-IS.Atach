
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ActivityMap : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasKey(t => t.ActivityId);

            builder.ToTable("Activity");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
        }
    }
}

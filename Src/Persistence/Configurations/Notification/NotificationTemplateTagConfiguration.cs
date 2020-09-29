using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Notification;

namespace MMK_IS.Atach.Persistence.Configurations.Notification
{
    public class NotificationTemplateTagConfiguration : IEntityTypeConfiguration<NotificationTemplateTag>
    {
        public void Configure(EntityTypeBuilder<NotificationTemplateTag> builder)
        {
            builder.HasKey(t => t.NotificationTemplateTagId);

            builder.ToTable("NotificationTemplateTag");

            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.LeftPart).HasColumnName("LeftPart");
            builder.Property(t => t.RightPart).HasColumnName("RightPart");
        }
    }
}

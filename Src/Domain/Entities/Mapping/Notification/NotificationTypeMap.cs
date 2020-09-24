using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Notification;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Notification
{
    public class NotificationTypeMap : IEntityTypeConfiguration<NotificationType>
    {
        public void Configure(EntityTypeBuilder<NotificationType> builder)
        {
            builder.HasKey(t => t.NotificationTypeId);

            builder.ToTable("NotificationType");

            builder.Property(t => t.Name).HasColumnName("Name");
        }
    }
}

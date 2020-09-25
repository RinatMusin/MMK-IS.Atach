using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MMK_IS.Atach.Persistence.Configurations.Notification
{
    public class NotificationMap : IEntityTypeConfiguration<MMK_IS.Atach.Domain.Entities.Notification.Notification>
    {
        public void Configure(EntityTypeBuilder<MMK_IS.Atach.Domain.Entities.Notification.Notification> builder)
        {
            builder.HasKey(t => t.NotificationId);

            builder.ToTable("Notification");

            builder.Property(t => t.Name).HasColumnName("Name");
        }
    }
}

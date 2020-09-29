using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Notification;

namespace MMK_IS.Atach.Persistence.Configurations.Notification
{
    public class NotificationTemplateVariableConfiguration : IEntityTypeConfiguration<NotificationTemplateVariable>
    {
        public void Configure(EntityTypeBuilder<NotificationTemplateVariable> builder)
        {
            builder.HasKey(t => t.NotificationTemplateVariableId);

            builder.ToTable("NotificationTemplateVariable");

            builder.Property(t => t.Key).HasColumnName("Key");
            builder.Property(t => t.Value).HasColumnName("Value");
        }
    }
}

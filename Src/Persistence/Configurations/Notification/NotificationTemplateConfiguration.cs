using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Notification;

namespace MMK_IS.Atach.Persistence.Configurations.Notification
{
    public class NotificationTemplateConfiguration : IEntityTypeConfiguration<NotificationTemplate>
    {
        public void Configure(EntityTypeBuilder<NotificationTemplate> builder)
        {
            builder.HasKey(t => t.NotificationTemplateId);

            builder.ToTable("NotificationTemplate");

            builder.Property(t => t.NofiticationTypeId).HasColumnName("NofiticationTypeId");
            builder.Property(t => t.NotificationId).HasColumnName("NotificationId");
            builder.Property(t => t.Template).HasColumnName("Template");
            builder.Property(t => t.SubjectTemplate).HasColumnName("SubjectTemplate");

            builder.HasOne(t => t.Notification).WithOne().IsRequired();
            builder.HasOne(t => t.Notification)
                .WithMany(t => t.Templates)
                .HasForeignKey(t => t.NotificationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.NotifiticationType).WithOne().IsRequired();
            builder.HasOne(t => t.NotifiticationType)
                .WithMany(t => t.NotificationTemplates)
                .HasForeignKey(t => t.NofiticationTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

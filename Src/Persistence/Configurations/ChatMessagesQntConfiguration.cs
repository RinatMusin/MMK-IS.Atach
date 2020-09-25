using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ChatMessagesQntMap : IEntityTypeConfiguration<ChatMessagesQnt>
    {
        public void Configure(EntityTypeBuilder<ChatMessagesQnt> builder)
        {
            builder.ToTable("ChatMessagesQnt");

            builder.HasKey(t => new { t.TaskId, t.UserId });

            builder.Property(t => t.UserId).HasColumnName("UserId");
            builder.Property(t => t.TaskId).HasColumnName("TaskId");
            builder.Property(t => t.DocumentId).HasColumnName("DocumentId");
            builder.Property(t => t.QntAllMessages).HasColumnName("QntAllMessages");
            builder.Property(t => t.QntUnreadedMessages).HasColumnName("QntUnreadedMessages");
            builder.Property(t => t.LastUpdateMessages).HasColumnName("LastUpdateMessages");

            builder.HasRequired(t => t.Task)
                .WithMany(t => t.ChatMessagesQnt)
                .HasForeignKey(t => t.TaskId)
                .WillCascadeOnDelete(true);
        }

    }
}





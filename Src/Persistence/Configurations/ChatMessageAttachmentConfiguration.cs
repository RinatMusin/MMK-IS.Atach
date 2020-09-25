using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ChatMessageAttachmentMap : IEntityTypeConfiguration<ChatMessageAttachment>
    {
        public void Configure(EntityTypeBuilder<ChatMessageAttachment> builder)
        {
            builder.HasKey(t => t.ChatMessageAttachmentId);

            builder.ToTable("ChatMessageAttachment");

            builder.Property(t => t.ChatMessageId).HasColumnName("ChatMessageId");
            builder.Property(t => t.ChatMessageAttachmentType).HasColumnName("ChatMessageAttachmentType").HasColumnType("varchar");
            builder.Property(t => t.ChatMessageAttachmentName).HasColumnName("ChatMessageAttachmentName").HasColumnType("varchar");
            builder.Property(t => t.ChatMessageAttachmentStatus).HasColumnName("ChatMessageAttachmentStatus").HasColumnType("varchar");
            builder.Property(t => t.CreationDate).HasColumnName("CreationDate");
            builder.Property(t => t.LastUpdateDate).HasColumnName("LastUpdateDate");

            builder.HasRequired(t => t.ChatMessage)
                .WithMany(t => t.ChatMessageAttachments)
                .HasForeignKey(t => t.ChatMessageId)
                .WillCascadeOnDelete(true);
        }

    }
}
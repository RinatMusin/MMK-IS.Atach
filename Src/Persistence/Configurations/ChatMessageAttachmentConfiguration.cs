using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ChatMessageAttachmentConfiguration : IEntityTypeConfiguration<ChatMessageAttachment>
    {
        public void Configure(EntityTypeBuilder<ChatMessageAttachment> builder)
        {
            builder.HasKey(t => t.ChatMessageAttachmentId);

            builder.ToTable("ChatMessageAttachment");

            builder.Property(t => t.ChatMessageId).HasColumnName("ChatMessageId");
            builder.Property(t => t.ChatMessageAttachmentType).HasColumnName("ChatMessageAttachmentType").HasMaxLength(8000);
            builder.Property(t => t.ChatMessageAttachmentName).HasColumnName("ChatMessageAttachmentName").HasMaxLength(8000);
            builder.Property(t => t.ChatMessageAttachmentStatus).HasColumnName("ChatMessageAttachmentStatus").HasMaxLength(8000);
            builder.Property(t => t.CreationDate).HasColumnName("CreationDate");
            builder.Property(t => t.LastUpdateDate).HasColumnName("LastUpdateDate");

            builder.HasOne(t => t.ChatMessage).WithOne().IsRequired();
            builder.HasOne(t => t.ChatMessage)
                .WithMany(t => t.ChatMessageAttachments)
                .HasForeignKey(t => t.ChatMessageId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
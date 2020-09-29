using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ChatMessageReadedConfiguration : IEntityTypeConfiguration<ChatMessageReaded>
    {
        public void Configure(EntityTypeBuilder<ChatMessageReaded> builder)
        {
            builder.HasKey(t => t.ChatMessageReadedStatusId);

            builder.ToTable("ChatMessageReaded");

            builder.Property(t => t.ChatMessageId).HasColumnName("ChatMessageId");
            builder.Property(t => t.ChatMemberId).HasColumnName("ChatMemberId");
            builder.Property(t => t.ChatMessageReadedStatus).HasColumnName("ChatMessageReadedStatus").HasColumnType("varchar");
            builder.Property(t => t.CreationDate).HasColumnName("CreationDate");
            builder.Property(t => t.LastUpdateDate).HasColumnName("LastUpdateDate");
            builder.Property(t => t.UserId).HasColumnName("UserId");
            builder.Property(t => t.DocumentId).HasColumnName("DocumentId");
            builder.Property(t => t.ChatId).HasColumnName("ChatId");

            builder.Property(t => t.ChatMember).IsRequired();
            builder.HasOne(t => t.ChatMember)
                .WithMany(t => t.ChatMessageReadeds)
                .HasForeignKey(t => t.ChatMemberId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.ChatMessage).IsRequired();
            builder.HasOne(t => t.ChatMessage)
                .WithMany(t => t.ChatMessageReadeds)
                .HasForeignKey(t => t.ChatMessageId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }

}
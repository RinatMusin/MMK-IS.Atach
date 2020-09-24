using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ChatMessageMap : IEntityTypeConfiguration<ChatMessage>
    {
        public void Configure(EntityTypeBuilder<ChatMessage> builder)
        {
            builder.HasKey(t => t.ChatMessageId);

            builder.ToTable("ChatMessage");

            builder.Property(t => t.ChatId).HasColumnName("ChatId");
            builder.Property(t => t.ChatMemberId).HasColumnName("ChatMemberId");
            builder.Property(t => t.ChatMessageText).HasColumnName("ChatMessageText").HasColumnType("varchar");
            builder.Property(t => t.CreationDate).HasColumnName("CreationDate");
            builder.Property(t => t.LastUpdateDate).HasColumnName("LastUpdateDate");
            builder.Property(t => t.ChatMessageStatus).HasColumnName("ChatMessageStatus");
            builder.Property(t => t.ChatAvatarImageLink).HasColumnName("ChatAvatarImageLink");

            builder.HasRequired(t => t.ChatMember)
                .WithMany(t => t.ChatMessages)
                .HasForeignKey(t => t.ChatMemberId)
                .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.Chat)
                .WithMany(t => t.ChatMessages)
                .HasForeignKey(t => t.ChatId)
                .WillCascadeOnDelete(true);

        }
    }

}

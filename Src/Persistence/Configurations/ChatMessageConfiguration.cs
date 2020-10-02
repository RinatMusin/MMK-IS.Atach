using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ChatMessageConfiguration : IEntityTypeConfiguration<ChatMessage>
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

            builder.HasOne(t => t.ChatMember).WithOne().IsRequired();
            builder.HasOne(t => t.ChatMember)
                .WithMany(t => t.ChatMessages)
                .HasForeignKey(t => t.ChatMemberId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Chat).WithOne().IsRequired();
            builder.HasOne(t => t.Chat)
                .WithMany(t => t.ChatMessages)
                .HasForeignKey(t => t.ChatId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }

}

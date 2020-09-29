using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{

    public class ChatConfiguration : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.HasKey(t => t.ChatId);

            builder.ToTable("Chat");

            builder.Property(t => t.DocumentId).HasColumnName("DocumentId");
            builder.Property(t => t.ComplexChatId).HasColumnName("ComplexChatId");
            builder.Property(t => t.ChatCreatedProfileId).HasColumnName("ChatCreatedProfileId");
            builder.Property(t => t.ChatName).HasColumnName("ChatName").HasColumnType("varchar");
            builder.Property(t => t.IsPublicChat).HasColumnName("IsPublicChat");
            builder.Property(t => t.ChatAvatarImageLink).HasColumnName("ChatAvatarImageLink").HasColumnType("varchar");
            builder.Property(t => t.ChatDescription).HasColumnName("ChatDescription").HasColumnType("varchar");
            builder.Property(t => t.CreationDate).HasColumnName("CreationDate");
            builder.Property(t => t.LastUpdateDate).HasColumnName("LastUpdateDate");

            builder.Property(t => t.ChatCreatedProfile).IsRequired();
            builder.HasOne(t => t.ChatCreatedProfile)
                .WithMany(t => t.Chats)
                .HasForeignKey(t => t.ChatCreatedProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.Document).IsRequired();
            builder.HasOne(t => t.Document)
                .WithMany(t => t.Chats)
                .HasForeignKey(t => t.DocumentId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}





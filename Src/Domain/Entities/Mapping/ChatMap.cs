using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{

    public class ChatMap : IEntityTypeConfiguration<Chat>
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

            builder.HasRequired(t => t.ChatCreatedProfile)
                .WithMany(t => t.Chats)
                .HasForeignKey(t => t.ChatCreatedProfileId)
                .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.Document)
                .WithMany(t => t.Chats)
                .HasForeignKey(t => t.DocumentId)
                .WillCascadeOnDelete(true);
        }

    }
}





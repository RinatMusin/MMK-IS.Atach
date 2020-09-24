using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ChatMemberMap : IEntityTypeConfiguration<ChatMember>
    {
        public void Configure(EntityTypeBuilder<ChatMember> builder)
        {
            builder.HasKey(t => t.ChatMemberId);

            builder.ToTable("ChatMember");

            builder.Property(t => t.ChatId).HasColumnName("ChatId");
            builder.Property(t => t.ChatMemberProfileId).HasColumnName("ChatMemberProfileId");
            //   builder.Property(t => t.DelegatingUserProfileId).HasColumnName("DelegatingUserProfileId");
            builder.Property(t => t.CreationDate).HasColumnName("CreationDate");
            builder.Property(t => t.LastUpdateDate).HasColumnName("LastUpdateDate");

            builder.HasRequired(t => t.ChatMemberProfile)
                .WithMany(t => t.ChatMembers)
                .HasForeignKey(t => t.ChatMemberProfileId)
                .WillCascadeOnDelete(true);

            //this.HasRequired(t => t.DelegatingUserProfile)
            //    .WithMany(t => t.ChatMembers)
            //    .HasForeignKey(t => t.DelegatingUserProfileId)
            //    .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.Chat)
                .WithMany(t => t.ChatMembers)
                .HasForeignKey(t => t.ChatId)
                .WillCascadeOnDelete(true);
        }

    }
}





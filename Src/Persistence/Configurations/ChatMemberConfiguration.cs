using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ChatMemberConfiguration : IEntityTypeConfiguration<ChatMember>
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

            builder.HasOne(t => t.ChatMemberProfile).WithOne().IsRequired();
            builder.HasOne(t => t.ChatMemberProfile)
               .WithMany(t => t.ChatMembers)
               .HasForeignKey(t => t.ChatMemberProfileId)
               .OnDelete(DeleteBehavior.Cascade);

            //this.HasRequired(t => t.DelegatingUserProfile)
            //    .WithMany(t => t.ChatMembers)
            //    .HasForeignKey(t => t.DelegatingUserProfileId)
            //    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Chat).WithOne().IsRequired();
            builder.HasOne(t => t.Chat)
                .WithMany(t => t.ChatMembers)
                .HasForeignKey(t => t.ChatId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}





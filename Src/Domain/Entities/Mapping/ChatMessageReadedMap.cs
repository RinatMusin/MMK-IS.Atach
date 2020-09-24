﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ChatMessageReadedMap : IEntityTypeConfiguration<ChatMessageReaded>
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

            builder.HasRequired(t => t.ChatMember)
                .WithMany(t => t.ChatMessageReadeds)
                .HasForeignKey(t => t.ChatMemberId)
                .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.ChatMessage)
                .WithMany(t => t.ChatMessageReadeds)
                .HasForeignKey(t => t.ChatMessageId)
                .WillCascadeOnDelete(true);

        }
    }

}
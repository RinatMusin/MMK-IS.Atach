﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Dictionary
{
    public class UserParticipantMap : IEntityTypeConfiguration<DictionaryUserParticipant>
    {
        public void Configure(EntityTypeBuilder<DictionaryUserParticipant> builder)
        {
            builder.HasKey(t => t.UserParticipantId);

            builder.ToTable("Dictionary_UserParticipant");

            builder.Property(t => t.GroupParticipantId).HasColumnName("GroupParticipantId");
            builder.Property(t => t.GroupParticipantName).HasColumnName("GroupParticipantName");
            builder.Property(t => t.UserId).HasColumnName("UserId");
            builder.Property(t => t.UserName).HasColumnName("UserName");

            builder.HasRequired(t => t.GroupParticipant)
                .WithMany(t => t.UserParticipants)
                .HasForeignKey(t => t.GroupParticipantId)
                .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.User)
                .WithMany(t => t.UserParticipants)
                .HasForeignKey(t => t.UserId)
                .WillCascadeOnDelete(false);



        }
    }
}
﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ClientProfileReplacementMap : IEntityTypeConfiguration<ClientProfileReplacement>
    {
        public void Configure(EntityTypeBuilder<ClientProfileReplacement> builder)
        {
            builder.HasKey(t => t.ReplacementId);

            builder.ToTable("ClientProfile_Replacement");

            builder.Property(t => t.UserId).HasColumnName("UserId");
            builder.Property(t => t.UserReplacementId).HasColumnName("UserReplacementId");
            builder.Property(t => t.EndTime).HasColumnName("EndTime");
            builder.Property(t => t.StartTime).HasColumnName("StartTime");
            builder.Property(t => t.IsDisabled).HasColumnName("IsDisabled");

            builder.HasRequired(t => t.User)
                .WithMany(t => t.ReplacementUsers)
                .HasForeignKey(t => t.UserId)
                .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.UserReplacement)
                .WithMany(t => t.ClientProfileReplacements)
                .HasForeignKey(t => t.UserReplacementId)
                .WillCascadeOnDelete(true);
        }
    }
}
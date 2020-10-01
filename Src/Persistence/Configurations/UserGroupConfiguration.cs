﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class UserGroupConfiguration : IEntityTypeConfiguration<UserGroup>
    {
        public void Configure(EntityTypeBuilder<UserGroup> builder)
        {
            builder.ToTable("User_Group");

            builder.HasKey(t => t.UserGroupId);

            builder.Property(t => t.UserId).HasColumnName("ClientProfileId");

            builder.Property(t => t.GroupId).HasColumnName("GroupId");

            builder.Property(t => t.User).IsRequired();
            builder.HasOne(t => t.User)
                .WithMany(t => t.UserGroups)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.Group).IsRequired();
            builder.HasOne(t => t.Group)
                .WithMany(t => t.UserGroups)
                .HasForeignKey(t => t.GroupId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
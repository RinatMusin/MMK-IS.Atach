﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class UserGroupAssignMap : IEntityTypeConfiguration<UserGroupAssign>
    {
        public void Configure(EntityTypeBuilder<UserGroupAssign> builder)
        {
            builder.ToTable("User_Group_Assign");

            builder.HasKey(t => t.UserGroupAssignId);

            builder.Property(t => t.UserId).HasColumnName("ClientProfileId");

            builder.Property(t => t.GroupAssignId).HasColumnName("GroupAssignId");

            builder.Property(t => t.User).IsRequired();
            builder.HasOne(t => t.User)
                .WithMany(t => t.UserGroupAssigns)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.GroupAssign).IsRequired();
            builder.HasOne(t => t.GroupAssign)
                .WithMany(t => t.UserGroupsAssign)
                .HasForeignKey(t => t.GroupAssignId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

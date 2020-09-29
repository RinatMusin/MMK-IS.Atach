﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ApplicationRoleActivityConfiguration : IEntityTypeConfiguration<ApplicationRoleActivity>
    {
        public void Configure(EntityTypeBuilder<ApplicationRoleActivity> builder)
        {
            builder.HasKey(t => t.ApplicationRoleActivityId);

            builder.ToTable("Application_Role_Activity");

            builder.Property(t => t.ActivityId).HasColumnName("ActivityId");
            builder.Property(t => t.RoleId).HasColumnName("RoleId");

            
           
            builder.Property(t => t.Activity).IsRequired();            
            builder.HasOne(t => t.Activity).WithMany(t => t.ApplicationRoleActivities).HasForeignKey(t => t.ActivityId);

            builder.Property(t => t.ApplicationRole).IsRequired();
            builder.HasOne(t => t.ApplicationRole).WithMany(t => t.ApplicationRoleActivities).HasForeignKey(t => t.RoleId);
        }

    }
}

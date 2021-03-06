﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class UserOrganizationConfiguration : IEntityTypeConfiguration<UserOrganization>
    {
        public void Configure(EntityTypeBuilder<UserOrganization> builder)
        {
            // Primary Key
            builder.HasKey(t => t.UserOrganizationId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Organization");

            builder.Property(t => t.OrganizationTypeId).HasColumnName("OrganizationTypeId");
            builder.Property(t => t.Name).HasColumnName("Name").HasMaxLength(8000);

            builder.HasOne(t => t.UserOrganizationType).WithOne().IsRequired();
            builder.HasOne(t => t.UserOrganizationType)
              .WithMany(t => t.UserOrganizations)
              .HasForeignKey(t => t.OrganizationTypeId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.ParentUserOrganization)
                .WithMany()
                .HasForeignKey(d => d.ParentOrganizationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

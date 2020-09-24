﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class WorkplaceMap : IEntityTypeConfiguration<Workplace>
    {
        public void Configure(EntityTypeBuilder<Workplace> builder)
        {
            builder.HasKey(t => t.WorkplaceId);

            builder.ToTable("Workplace");

            builder.Property(t => t.OrganizationId).HasColumnName("OrganizationId");
            builder.Property(t => t.ParentWorkplaceId).HasColumnName("ParentWorkplaceId");
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");

            builder.HasRequired(t => t.UserOrganization)
                .WithMany(t => t.Workplaces)
                .HasForeignKey(t => t.OrganizationId)
                .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.ParentWorkplace)
                .WithMany()
                .HasForeignKey(t => t.ParentWorkplaceId)
                .WillCascadeOnDelete(true);
        }
    }

}
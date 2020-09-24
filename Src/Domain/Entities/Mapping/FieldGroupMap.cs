﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class FieldGroupMap : IEntityTypeConfiguration<FieldGroup>
    {
        public void Configure(EntityTypeBuilder<FieldGroup> builder)
        {
            // Primary Key
            builder.HasKey(t => t.FieldGroupId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Filed_Group");

            builder.Property(t => t.ParentFieldGroupId).HasColumnName("ParentFieldGroupId");
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar"); ;
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
            builder.Property(t => t.State).HasColumnName("State").HasColumnType("varchar"); ;
            builder.Property(t => t.CreationDate).HasColumnName("CreationDate");
            builder.Property(t => t.LastUpdate).HasColumnName("LastUpdate");

            // Relationships
            builder.HasOne(t => t.ParentFieldGroup)
                .WithMany()
                .HasForeignKey(d => d.ParentFieldGroupId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class RouteActionFieldMap : IEntityTypeConfiguration<RouteActionField>
    {
        public void Configure(EntityTypeBuilder<RouteActionField> builder)
        {
            builder.HasKey(t => t.ActionFieldId);

            builder.ToTable("Route_Action_Field");

            builder.Property(t => t.RouteActionId).HasColumnName("RouteActionId");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.ParentFieldId).HasColumnName("ParentFieldId");
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
            builder.Property(t => t.Color).HasColumnName("Color");


            builder.HasRequired(t => t.RouteActionFieldType)
                .WithMany(t => t.RouteActionFields)
                .HasForeignKey(t => t.RouteActionFieldTypeId)
                .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.RouteAction)
                .WithMany(t => t.ActionFields)
                .HasForeignKey(t => t.RouteActionId)
                .WillCascadeOnDelete(true);

        }
    }
}

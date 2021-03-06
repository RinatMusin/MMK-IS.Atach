﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ComponentConfiguration : IEntityTypeConfiguration<Component>
    {
        public void Configure(EntityTypeBuilder<Component> builder)
        {
            builder.ToTable("Component");

            builder.HasKey(t => t.ComponentId);

            builder.Property(t => t.ViewPanelId).HasColumnName("ViewPanelId");
            builder.Property(t => t.SystemName).HasColumnName("SystemName").HasMaxLength(8000);
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");

            builder.HasOne(t => t.ViewPanel).WithOne().IsRequired();
            builder.HasOne(t => t.ViewPanel)
                .WithMany(t => t.Components)
                .HasForeignKey(t => t.ViewPanelId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

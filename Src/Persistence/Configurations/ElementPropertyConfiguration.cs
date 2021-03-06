﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ElementPropertyConfiguration : IEntityTypeConfiguration<ElementProperty>
    {
        public void Configure(EntityTypeBuilder<ElementProperty> builder)
        {
            builder.ToTable("ElementProperty");

            builder.HasKey(t => t.ElementPropertyId);

            builder.Property(t => t.ElementId).HasColumnName("ElementId");
            builder.Property(t => t.Key).HasColumnName("Key").HasMaxLength(8000);
            builder.Property(t => t.Value).HasColumnName("Value").HasMaxLength(8000);

            builder.HasOne(t => t.Element).WithOne().IsRequired();
            builder.HasOne(t => t.Element)
                .WithMany(t => t.ElementProperties)
                .HasForeignKey(d => d.ElementId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

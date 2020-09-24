﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class StampPositionMap : IEntityTypeConfiguration<StampPosition>
    {
        public void Configure(EntityTypeBuilder<StampPosition> builder)
        {
            builder.HasKey(t => t.StampPositionId);

            builder.ToTable("Stamp_Position");

            builder.Property(t => t.Position).HasColumnName("Position").HasColumnType("varchar");
            builder.Property(t => t.MarginBottom).HasColumnName("MarginBottom");
            builder.Property(t => t.MarginLeft).HasColumnName("MarginLeft");
            builder.Property(t => t.MarginRight).HasColumnName("MarginRight");
            builder.Property(t => t.MarginTop).HasColumnName("MarginTop");
            builder.Property(t => t.IsDefault).HasColumnName("IsDefault");

            builder.HasRequired(t => t.StampPositionType)
                .WithMany(t => t.StampPositions)
                .HasForeignKey(t => t.StampPositionTypeId);
        }
    }

}
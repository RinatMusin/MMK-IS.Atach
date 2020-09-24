﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Dictionary
{
    public class DictionaryPropertyMap : IEntityTypeConfiguration<DictionaryProperty>
    {
        public void Configure(EntityTypeBuilder<DictionaryProperty> builder)
        {
            builder.HasKey(t => t.PropertyId);

            builder.ToTable("DictionaryProperty");

            builder.Property(t => t.PropertyId).HasColumnName("PropertyId");
            builder.Property(t => t.PropertyTypeId).HasColumnName("PropertyTypeId");
            builder.Property(t => t.Name).HasColumnName("Name");

            builder.HasRequired(t => t.PropertyType)
                .WithMany(t => t.Properties)
                .HasForeignKey(t => t.PropertyTypeId)
                .WillCascadeOnDelete(true);
        }
    }
}
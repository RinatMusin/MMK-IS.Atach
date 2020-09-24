﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Dictionary
{
    public class OrganizationMap : IEntityTypeConfiguration<DictionaryOrganization>
    {
        public void Configure(EntityTypeBuilder<DictionaryOrganization> builder)
        {
            builder.HasKey(t => t.OrganizationId);

            builder.ToTable("Dictionary_Organization");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
        }
    }
}
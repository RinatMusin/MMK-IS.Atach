﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    class CardTemplateConfiguration : IEntityTypeConfiguration<CardTemplate>
    {
        public void Configure(EntityTypeBuilder<CardTemplate> builder)
        {
            builder.HasKey(t => t.CardTemplateId);
            builder.ToTable("CardTemplates");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("character varying");
        }

    }
}

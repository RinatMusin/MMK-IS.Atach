﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class DeliveryDirectionConfiguration : IEntityTypeConfiguration<DeliveryDirection>
    {
        public void Configure(EntityTypeBuilder<DeliveryDirection> builder)
        {
            builder.HasKey(t => t.DeliveryDirectionId);

            builder.ToTable("Dictionary_DeliveryDirection");

            builder.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
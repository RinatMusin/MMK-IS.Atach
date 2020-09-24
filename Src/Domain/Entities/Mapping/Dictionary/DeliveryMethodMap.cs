﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Dictionary
{
    public class DeliveryMethodMap : IEntityTypeConfiguration<DeliveryMethod>
    {
        public void Configure(EntityTypeBuilder<DeliveryMethod> builder)

        {
            builder.HasKey(t => t.DeliveryMethodId);

            builder.ToTable("Dictionary_Delivery_Method");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
            builder.Property(t => t.DeliveryMethodType).HasColumnName("DeliveryMethodType").HasColumnType("varchar");

        }

    }
}
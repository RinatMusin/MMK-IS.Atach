﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Dictionary
{
    public class PaymentMethodMap : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(t => t.PaymentMethodId);

            builder.ToTable("Dictionary_PaymentMethod");

            builder.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
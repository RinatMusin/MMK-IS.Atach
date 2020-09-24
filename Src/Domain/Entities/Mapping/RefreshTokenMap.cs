﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class RefreshTokenMap : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(t => t.RefreshTokenId);

            builder.ToTable("RefreshToken");

            builder.Property(t => t.Subject).HasColumnName("Subject").IsRequired();
            builder.Property(t => t.ClientId).HasColumnName("ClientId").IsRequired();
            builder.Property(t => t.ExpiresUtc).HasColumnName("ExpiresUtc");
            builder.Property(t => t.IssuedUtc).HasColumnName("IssuedUtc");
            builder.Property(t => t.ProtectedTicket).HasColumnName("ProtectedTicket").IsRequired();


            builder.HasRequired(t => t.Client)
                .WithMany(t => t.RefreshTokens)
                .HasForeignKey(t => t.ClientId);

        }
    }
    
}
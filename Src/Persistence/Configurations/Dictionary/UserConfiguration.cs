﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class UserConfiguration : IEntityTypeConfiguration<DictionaryUser>
    {
        public void Configure(EntityTypeBuilder<DictionaryUser> builder)
        {
            builder.HasKey(t => t.UserId);

            builder.ToTable("Dictionary_OrganizationContact");

            builder.Property(t => t.OrganizationId).HasColumnName("OrganizationId");
            builder.Property(t => t.FullName).HasColumnName("FullName");
            builder.Property(t => t.Email).HasColumnName("Email");
            builder.Property(t => t.Position).HasColumnName("Position");

            builder.HasOne(t => t.Organization).WithOne().IsRequired();
            builder.HasOne(t => t.Organization)
                .WithMany(t => t.Users)
                .HasForeignKey(t => t.OrganizationId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}

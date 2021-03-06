﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class FilePageConfiguration : IEntityTypeConfiguration<FilePage>
    {
        public void Configure(EntityTypeBuilder<FilePage> builder)
        {
            // Primary Key
            builder.HasKey(t => t.FilePageId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("File_Page");

            builder.Property(t => t.FileId).HasColumnName("FileId");
            builder.Property(t => t.PageImage).HasColumnName("FirstPageImage");
            builder.Property(t => t.PageNumber).HasColumnName("PageCount");
            builder.Property(t => t.CreateDate).HasColumnName("InsertDate");

            // Relationships
            builder.HasOne(t => t.File).WithOne().IsRequired();
            builder.HasOne(t => t.File)
                .WithMany(t => t.FilePages)
                .HasForeignKey(d => d.FileId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}

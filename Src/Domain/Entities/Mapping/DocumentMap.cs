﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{

    public class DocumentMap : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasKey(t => t.DocumentId);

            builder.ToTable("Document");

            builder.Property(t => t.DocumentTypeId).HasColumnName("DocumentTypeId");
            builder.Property(t => t.DocumentStatusId).HasColumnName("DocumentStatusId");
            builder.Property(t => t.CreatedUserId).HasColumnName("CreatedUserId");
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
            builder.Property(t => t.Keywords).HasColumnName("Keywords").HasColumnType("text");
            builder.Property(t => t.Counterparty).HasColumnName("Counterparty").HasColumnType("varchar");
            builder.Property(t => t.Description).HasColumnName("Description").HasColumnType("varchar"); 
            builder.Property(t => t.CreationDate).HasColumnName("CreationDate");
            builder.Property(t => t.LastUpdateDate).HasColumnName("LastUpdateDate");
            builder.Property(t => t.IsForReview).HasColumnName("IsForReview");
            builder.Property(t => t.IsForReplacement).HasColumnName("IsForReplacement");
            builder.Property(t => t.IsForTask).HasColumnName("IsForTask");

            builder.HasRequired(t => t.DocumentType)
             .WithMany(t => t.Documents)
             .HasForeignKey(t => t.DocumentTypeId)
             .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.CreationUser)
                .WithMany(t => t.Documents)
                .HasForeignKey(t => t.CreatedUserId)
                .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.DocumentStatus)
                .WithMany(t => t.Documents)
                .HasForeignKey(t => t.DocumentStatusId)
                .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.ParentDocument)
              .WithMany()
              .HasForeignKey(d => d.ParentDocumentId)
              .WillCascadeOnDelete(false);

        }

    }
}
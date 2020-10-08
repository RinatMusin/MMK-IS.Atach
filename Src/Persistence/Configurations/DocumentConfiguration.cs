using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{

    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasKey(t => t.DocumentId);

            builder.ToTable("Document");

            builder.Property(t => t.DocumentTypeId).HasColumnName("DocumentTypeId");
            builder.Property(t => t.DocumentStatusId).HasColumnName("DocumentStatusId");
            builder.Property(t => t.CreatedUserId).HasColumnName("CreatedUserId");
            builder.Property(t => t.Name).HasColumnName("Name").HasMaxLength(8000);
            builder.Property(t => t.Keywords).HasColumnName("Keywords").HasColumnType("text");
            builder.Property(t => t.Counterparty).HasColumnName("Counterparty").HasMaxLength(8000);
            builder.Property(t => t.Description).HasColumnName("Description").HasMaxLength(8000);
            builder.Property(t => t.CreationDate).HasColumnName("CreationDate");
            builder.Property(t => t.LastUpdateDate).HasColumnName("LastUpdateDate");
            builder.Property(t => t.IsForReview).HasColumnName("IsForReview");
            builder.Property(t => t.IsForReplacement).HasColumnName("IsForReplacement");
            builder.Property(t => t.IsForTask).HasColumnName("IsForTask");

            builder.HasOne(t => t.DocumentType).WithOne().IsRequired();
            builder.HasOne(t => t.DocumentType)
             .WithMany(t => t.Documents)
             .HasForeignKey(t => t.DocumentTypeId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.CreationUser).WithOne().IsRequired();
            builder.HasOne(t => t.CreationUser)
                .WithMany(t => t.Documents)
                .HasForeignKey(t => t.CreatedUserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.DocumentStatus).WithOne().IsRequired();
            builder.HasOne(t => t.DocumentStatus)
                .WithMany(t => t.Documents)
                .HasForeignKey(t => t.DocumentStatusId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.ParentDocument)
              .WithMany()
              .HasForeignKey(d => d.ParentDocumentId)
              .OnDelete(DeleteBehavior.Cascade);

        }

    }
}

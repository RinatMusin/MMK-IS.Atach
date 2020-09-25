using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class DocumentTypeMap : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {

            builder.HasKey(t => t.DocumentTypeId);

            builder.ToTable("Document_Type");
            builder.Property(t => t.DepartmentId).HasColumnName("DepartmentId");
            builder.Property(t => t.SequenceName).HasColumnName("SequenceName");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.RegistrationNumberTemplate).HasColumnName("RegistrationNumberTemplate");
            builder.Property(t => t.CreationPriority).HasColumnName("CreationPriority");
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
            builder.Property(t => t.IsInsertQRCode).HasColumnName("IsInsertQRCode");
            builder.Property(t => t.IsReplaceRegNumber).HasColumnName("IsReplaceRegNumber");


            builder.HasOne(t => t.ParentDocumentType)
              .WithMany()
              .HasForeignKey(t => t.ParentDocumentTypeId);

            builder.HasOne(t => t.Department)
                .WithMany(t => t.DocumentTypes)
                .HasForeignKey(t => t.DepartmentId);

            builder.HasOne(t => t.StampPosition)
                .WithMany(t => t.DocumentTypes)
                .HasForeignKey(t => t.StampPositionId);


        }
    }
}

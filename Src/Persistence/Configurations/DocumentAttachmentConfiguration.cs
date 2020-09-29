using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class AttachmentConfiguration : IEntityTypeConfiguration<DocumentAttachment>
    {
        public void Configure(EntityTypeBuilder<DocumentAttachment> builder)
        {
            builder.HasKey(t => t.DocumentAttachmentId);

            builder.ToTable("Document_Attachment");

            builder.Property(t => t.DocumentId).HasColumnName("DocumentId");

            builder.Property(t => t.DocumentAttachmentId).HasColumnName("AttachmentId");

            builder.Property(t => t.IsMainFile).HasColumnName("IsMainFile");

            builder.Property(t => t.Document).IsRequired();
            builder.HasOne(t => t.Document)
                .WithMany(t => t.DocumentAttachments)
                .HasForeignKey(t => t.DocumentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.File).IsRequired();
            builder.HasOne(t => t.File)
                .WithMany(t => t.DocumentAttachments)
                .HasForeignKey(t => t.FileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.ProcessingStatus).IsRequired();
            builder.HasOne(t => t.ProcessingStatus)
                .WithMany(t => t.Attachments)
                .HasForeignKey(t => t.ProcessingStatusId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

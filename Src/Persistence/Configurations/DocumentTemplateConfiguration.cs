using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class DocumentTemplateConfiguration : IEntityTypeConfiguration<DocumentTemplate>
    {
        public void Configure(EntityTypeBuilder<DocumentTemplate> builder)
        {
            builder.HasKey(t => t.DocumentTemplateId);

            builder.ToTable("Document_Template");

            builder.Property(t => t.DocumentTypeId).HasColumnName("DocumentTypeId");
            builder.Property(t => t.IsReply).HasColumnName("IsReply");
            builder.Property(t => t.Template).HasColumnName("Template");
            builder.Property(t => t.PreviewTemplate).HasColumnName("PreviewTemplate");
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");

            builder.Property(t => t.DocumentType).IsRequired();
            builder.HasOne(t => t.DocumentType)
                .WithMany(t => t.DocumentTemplates)
                .HasForeignKey(t => t.DocumentTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

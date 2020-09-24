using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class DocumentTemplateMap : IEntityTypeConfiguration<DocumentTemplate>
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

            builder.HasRequired(t => t.DocumentType)
                .WithMany(t => t.DocumentTemplates)
                .HasForeignKey(t => t.DocumentTypeId)
                .WillCascadeOnDelete(true);
        }
    }
}

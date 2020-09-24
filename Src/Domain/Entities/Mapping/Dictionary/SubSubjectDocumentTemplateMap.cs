using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Dictionary
{
    public class SubSubjectDocumentTemplateMap : IEntityTypeConfiguration<DictionarySubSubjectDocumentTemplate>
    {
        public void Configure(EntityTypeBuilder<DictionarySubSubjectDocumentTemplate> builder)
        {
            builder.HasKey(t => t.SubSubjectDocumentTemplateId);

            builder.ToTable("Dictionary_SubSubjectDocumentTemplate");

            builder.Property(t => t.SubSubjectDocumentTemplateId).HasColumnName("SubSubjectDocumentTemplateId");
            builder.Property(t => t.SubSubjectId).HasColumnName("SubSubjecId");
            builder.Property(t => t.DocumentTemplateId).HasColumnName("DocumentTemplateId");

            builder.HasRequired(t => t.SubSubject)
                .WithMany(t => t.SubSubjectDocumentTemplates)
                .HasForeignKey(t => t.SubSubjectId)
                .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.DocumentTemplate)
                .WithMany(t => t.DictionarySubSubjectDocumentTemplates)
                .HasForeignKey(t => t.DocumentTemplateId)
                .WillCascadeOnDelete(false);
        }
    }
}

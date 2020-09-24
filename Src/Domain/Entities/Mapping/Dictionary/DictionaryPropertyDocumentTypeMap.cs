using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Dictionary
{
    public class DictionaryPropertyDocumentTypeMap : IEntityTypeConfiguration<DictionaryPropertyDocumentType>
    {
        public void Configure(EntityTypeBuilder<DictionaryPropertyDocumentType> builder)
        {
            builder.HasKey(t => t.DictionaryPropertyDocumentTypeId);

            builder.ToTable("DictionaryPropertyDocumentTypes");
            builder.Property(t => t.PropertyId).HasColumnName("PropertyId");
            builder.Property(t => t.DocumentTypeId).HasColumnName("DocumentTypeId");

            builder.HasRequired(t => t.DictionaryProperty)
                .WithMany(t => t.DictionaryPropertyDocumentTypes)
                .HasForeignKey(t => t.PropertyId)
                .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.DocumentType)
                .WithMany(t => t.DictionaryPropertyDocumentTypes)
                .HasForeignKey(t => t.DocumentTypeId)
                .WillCascadeOnDelete(true);
        }
    }
}

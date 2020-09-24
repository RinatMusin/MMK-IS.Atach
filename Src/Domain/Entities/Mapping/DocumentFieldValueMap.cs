using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class DocumentFieldValueMap : IEntityTypeConfiguration<DocumentFieldValue>
    {
        public void Configure(EntityTypeBuilder<DocumentFieldValue> builder)
        {
            // Primary Key
            builder.HasKey(t => t.DocumentFieldValueId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Document_Field_Value");

            builder.Property(t => t.DocumentId).HasColumnName("DocumentId");
            builder.Property(t => t.CardFieldId).HasColumnName("CardFieldId");
            builder.Property(t => t.Value).HasColumnName("Value").HasColumnType("text");
            builder.Property(t => t.SearchableValue).HasColumnName("SearchableValue").HasColumnType("text");

            builder.HasRequired(t => t.CardField)
                .WithMany(t => t.DocumentFieldValues)
                .HasForeignKey(d => d.CardFieldId)
                .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.Document)
                .WithMany(t => t.DocumentFieldValues)
                .HasForeignKey(d => d.DocumentId)
                .WillCascadeOnDelete(true);

        }
    }
}

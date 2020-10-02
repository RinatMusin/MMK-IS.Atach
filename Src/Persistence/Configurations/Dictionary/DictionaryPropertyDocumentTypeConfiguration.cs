using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class DictionaryPropertyDocumentTypeConfiguration : IEntityTypeConfiguration<DictionaryPropertyDocumentType>
    {
        public void Configure(EntityTypeBuilder<DictionaryPropertyDocumentType> builder)
        {
            builder.HasKey(t => t.DictionaryPropertyDocumentTypeId);

            builder.ToTable("DictionaryPropertyDocumentTypes");
            builder.Property(t => t.PropertyId).HasColumnName("PropertyId");
            builder.Property(t => t.DocumentTypeId).HasColumnName("DocumentTypeId");

            builder.HasOne(t => t.DictionaryProperty).WithOne().IsRequired();
            builder.HasOne(t => t.DictionaryProperty)
                .WithMany(t => t.DictionaryPropertyDocumentTypes)
                .HasForeignKey(t => t.PropertyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.DocumentType).WithOne().IsRequired();
            builder.HasOne(t => t.DocumentType)
                .WithMany(t => t.DictionaryPropertyDocumentTypes)
                .HasForeignKey(t => t.DocumentTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

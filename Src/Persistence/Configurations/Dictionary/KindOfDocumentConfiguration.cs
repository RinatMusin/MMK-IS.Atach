using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class KindOfDocumentMap : IEntityTypeConfiguration<DictionaryKindOfDocument>
    {
        public void Configure(EntityTypeBuilder<DictionaryKindOfDocument> builder)
        {
            builder.HasKey(t => t.KindOfDocumentId);

            builder.ToTable("Dictionary_KindOfDocument");

            builder.Property(t => t.KindOfDocument).HasColumnName("KindOfDocument");
            builder.Property(t => t.SAPCode).HasColumnName("SAPCode");
        }

    }
}

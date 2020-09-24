using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Dictionary
{
    public class KindOfStatementMap : IEntityTypeConfiguration<DictionaryKindOfStatement>
    {
        public void Configure(EntityTypeBuilder<DictionaryKindOfStatement> builder)
        {
            builder.HasKey(t => t.KindOfStatementId);

            builder.ToTable("Dictionary_KindOfStatement");

            builder.Property(t => t.KindOfStatement).HasColumnName("KindOfStatement");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class KindOfOrderOZMap : IEntityTypeConfiguration<DictionaryKindOfOrderOZ>
    {
        public void Configure(EntityTypeBuilder<DictionaryKindOfOrderOZ> builder)
        {
            builder.HasKey(t => t.KindOfOrderOZId);

            builder.ToTable("Dictionary_KindOfOrderOZ");

            builder.Property(t => t.KindOfOrderOZ).HasColumnName("KindOfOrderOZ");
        }
    }
}
